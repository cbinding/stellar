/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Data.DBEngineBase
Summary	: base class for db access, see concrete implementation in SQLiteDBEngine
License : http://creativecommons.org/licenses/by/3.0/
================================================================================
History :

12/01/2011  CFB Created classes
================================================================================
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace STELLAR.Data
{
    // base class for database access - concrete implementation in e.g. SQLiteDBEngine
    public abstract class DBEngineBase: IDBEngine 
    {
        protected String m_connectionString;

        //Constructors
        public DBEngineBase() { }
        public DBEngineBase(String connectionString) 
        {
            m_connectionString = connectionString;
        }
        public DBEngineBase(IDictionary options) 
        {
            String str = "";
            foreach (KeyValuePair<string, string> row in options)
            {
                str += String.Format("{0}={1}; ", row.Key.Trim(), row.Value.Trim());
            }
            m_connectionString = str.Trim().Substring(0, str.Length - 1); 
        }
        
        //Build connection string from options KeyValuePairs
        //example: "Data Source=stellar.db3;Version=3;New=False;Compress=True;";
        public string getConnectionString(IDictionary options)
        {
            String str = "";
            foreach (KeyValuePair<String, String> row in options)
            {
                str += String.Format("{0}={1}; ", row.Key.Trim(), row.Value.Trim());
            }
            return str.Trim().Substring(0, str.Length - 1);           
        }

        //override these in concrete implementations...
        public abstract IDbConnection getConnection();
        public abstract IDbCommand getCommand(String sql);
        public abstract IDbCommand getCommand();
        public abstract String[] tables();
        public abstract String[] columns(String tableName);

        public DataTable select(String sql)
        {           
            IDbCommand cmd = getCommand(sql);
            return executeDT(cmd);           
        }        

        //Insert a single row
        public int insert(String tableName, IDictionary<string, string> data)
        {
            String columns = "";
            String values = "";

            //IDbCommand cmd = getCommand();
            System.Data.IDbCommand cmd = getCommand();
            
            foreach (KeyValuePair<string, string> pair in data)
            {
                columns += String.Format(" \"{0}\",", pair.Key);
                //values += String.Format(" '{@0}',", pair.Key.ToString()); //doesn't like this??
                values += " @" + pair.Key + ",";
                //values += " '" + pair.Value + "',";
                //cmd.Parameters.AddWithValue(pair.Key, pair.Value); 
                IDbDataParameter p = cmd.CreateParameter();                
                p.ParameterName = pair.Key;
                p.Value = pair.Value;
                cmd.Parameters.Add(p);                 
            }
            columns = columns.Substring(0, columns.Length - 1);
            values = values.Substring(0, values.Length - 1);
            String sql = String.Format("insert into \"{0}\" ({1}) values({2});", tableName, columns, values);
            cmd.CommandText = sql;
            try
            {
                return executeNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                cmd.Dispose();
            }
        }

        // faster bulk insert method for entire DataTable
        //(see http://sqlite.phxsoftware.com/forums/t/134.aspx)
        public int bulkInsert(DataTable dt) 
        {
            int rowCount = 0;
            IDbConnection cnn = getConnection();
            cnn.Open();            
            IDbTransaction dbTrans = cnn.BeginTransaction();
            IDbCommand cmd = getCommand();
            cmd.Connection = cnn;
            
            //Build the insert command
            String columns = "";
            string parameters = "";
            foreach (DataColumn dc in dt.Columns)
            {
                columns += String.Format(" \"{0}\",", dc.ColumnName);
                parameters += " @" + dc.ColumnName + ",";                
                IDbDataParameter p = cmd.CreateParameter();
                p.ParameterName = dc.ColumnName;
                cmd.Parameters.Add(p);
            }
            columns = columns.Remove(columns.LastIndexOf(','));
            parameters = parameters.Remove(parameters.LastIndexOf(','));
            cmd.CommandText = String.Format("INSERT INTO \"{0}\" ({1}) VALUES ({2})", dt.TableName, columns, parameters);

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        IDbDataParameter p = (IDbDataParameter)cmd.Parameters[dc.ColumnName];
                        p.Value = dr[dc];
                    }
                    rowCount += cmd.ExecuteNonQuery();
                }
                dbTrans.Commit();
            }
            catch (Exception ex)
            {
                dbTrans.Rollback();
                throw ex;
            }
            finally
            {
                cnn.Close();
                dbTrans.Dispose();
                cmd.Dispose();
                cnn.Dispose();
            }
            return rowCount;
        } 


        public int update(String tableName, IDictionary<string,string> data, String where)
        {
            String values = "";
            
            if (data.Count >= 1)
            {
                foreach (KeyValuePair<string, string> pair in data)
                {
                    values += String.Format(" \"{0}\" = '{1}',", pair.Key.ToString(), pair.Value.ToString());
                }
                //Remove trailing comma
                values = values.Substring(0, values.Length - 1);
            }
            try
            {
                return executeNonQuery(String.Format("update \"{0}\" set {1} where {2};", tableName, values, where));
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public int delete(String tableName, String where)
        {
            try
            {
                return executeNonQuery(String.Format("delete from \"{0}\" where {1};", tableName, where));
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public int count(String tableName)
        {
            return count(tableName, "");
        }
        public int count(String tableName, String where)
        {
            try
            {
                String sql = String.Format("SELECT count(*) from \"{0}\"", tableName);
                if (where.Trim().Length > 0)
                    sql += String.Format(" WHERE {1}", where);
                sql += ";";
                String s = executeScalar(sql);
                int value = 0;
                if (Int32.TryParse(s, out value))
                    return value;
                else
                    return 0;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public int delete(String tableName)
        {
            try
            {
                return executeNonQuery(String.Format("delete from \"{0}\";", tableName));
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }        

        public int executeNonQuery(String sql)
        {
            IDbCommand cmd = getCommand(sql);
            return executeNonQuery(cmd);
        }
        private int executeNonQuery(IDbCommand cmd)
        {
            IDbConnection con = getConnection();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            int i = 0;

            con.Open();
            IDbTransaction dbTrans = con.BeginTransaction(); 

            try
            {                           
                i = cmd.ExecuteNonQuery();
                dbTrans.Commit();
            }
            catch(Exception ex)
            {
                dbTrans.Rollback();
                throw ex;                
            }
            finally
            {
                con.Close();
                dbTrans.Dispose();
                con.Dispose();
            }
            return i;
        }          

        public string executeScalar(String sql)
        {
            IDbCommand cmd = getCommand(sql);
            IDbConnection con = getConnection();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;

            try
            {
                con.Open();
                object value = cmd.ExecuteScalar();
                if (value != null)
                    return value.ToString();
                else
                    return "";
                //how to get id of last inserted record:
                //append to Query: ";SELECT last_insert_rowid() as [ID]" 
                //then run: string lastID = executeScalar().ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private DataTable executeDT(IDbCommand cmd)
        {
            IDbConnection con = getConnection();
            DataTable dt = new DataTable();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;

            try
            {
                con.Open();
                IDataReader dr = (IDataReader)cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }    
    }
}
