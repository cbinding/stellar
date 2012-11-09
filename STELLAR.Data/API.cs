/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Data.API
Summary	: Data conversion functionality
License : http://creativecommons.org/licenses/by/3.0/
================================================================================
History :

12/01/2011  CFB Created classes
21/10/2011  CFB Added functionality to pass options file data to STG templates
================================================================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using FileHelpers;              // external library for CSV I/O
using SemWeb;                   // external library for rdfMerge
using Antlr4.StringTemplate;    // external library for StringTemplate

//using Antlr3.ST;              // external library for StringTemplate
//using Antlr3.ST.Language;     // external library for StringTemplate

namespace STELLAR.Data
{    
    //Main functionality for STELLAR app
    public static class API
    {
        //Upload delimited file to a table in the database, return number of rows inserted
        public static int Delimited2DB(string dbName, string fileName)
        {
            return Delimited2DB(dbName, fileName, false);
        }
        public static int Delimited2DB(string dbName, string fileName, char delimiter)
        {
            return Delimited2DB(dbName, fileName, delimiter, false);
        }
        public static int Delimited2DB(string dbName, string fileName, char delimiter, bool hasHeader)
        {
            return Delimited2DB(dbName, fileName, "", delimiter, hasHeader, false);
        }
        public static int Delimited2DB(string dbName, string fileName, bool hasHeader)
        {
            return Delimited2DB(dbName, fileName, "", hasHeader);
        }
        public static int Delimited2DB(string dbName, string fileName, string tableName)
        {
            return Delimited2DB(dbName, fileName, tableName, false);
        }
        public static int Delimited2DB(string dbName, string fileName, string tableName, bool hasHeader)
        {
            return Delimited2DB(dbName, fileName, tableName, ',', hasHeader, false);
        }
        public static int Delimited2DB(string dbName, string fileName, string tableName, bool hasHeader, bool append)
        {
            return Delimited2DB(dbName, fileName, tableName, ',', hasHeader, append);
        }
        public static int Delimited2DB(string dbName, string fileName, string tableName, char delimiter, bool hasHeader, bool append)
        {
            //Tidy up input parameters
            dbName = dbName.Trim();
            fileName = fileName.Trim();
            tableName = tableName.Trim().ToLower();

            //Fail if dbName or csvFileName not passed in
            if (dbName == String.Empty)
                throw new ArgumentException("database name required", "dbName");
            if (fileName == String.Empty)
                throw new ArgumentException("file name required", "fileName");

            //If table name not passed in - generate it from file name             
            if (tableName == "")
                tableName = System.IO.Path.GetFileNameWithoutExtension(fileName).Trim().ToLower();
            tableName = getValidTableName(tableName);

            //Do the import
            DataTable dt = Delimited2DT(fileName, delimiter, hasHeader);
            dt.TableName = tableName;
            return DT2DB(dbName, dt, append);
        }

        //Write DataTable to database, recreate the table first to ensure structure is correct
        public static int DT2DB(String dbName, DataTable table, bool append)
        {
            // Why didnt I use IDBEngine here? test...
            // IDBEngine db = new SQLiteDBEngine(dbName);            
            DBEngineBase db = new SQLiteDBEngine(dbName);

            if (!append)
            {
                //Drop the table if it already exists  
                db.executeNonQuery(String.Format("DROP TABLE IF EXISTS \"{0}\";", table.TableName));

                //Create the table based on the structure of the DataTable
                String sql = String.Format("CREATE TABLE \"{0}\" (", table.TableName);
                foreach (DataColumn dc in table.Columns)
                {
                    //Column names should already be valid (CSV2DT cleaned them up)
                    //sql += String.Format("\"{0}\" TEXT NOT NULL DEFAULT '',", dc.ColumnName);
                    //sql += String.Format("\"{0}\" TEXT,", dc.ColumnName);//04/03/2010 - ensure case insensitive comparisons
                    sql += String.Format("\"{0}\" TEXT COLLATE NOCASE,", dc.ColumnName);
                }

                //remove the last comma, complete and run the command
                sql = sql.Remove(sql.LastIndexOf(',')) + ");";
                db.executeNonQuery(sql);
            }

            //Created the table, now insert the data
            return db.bulkInsert(table);
        }

        // Execute SQL command(s) against named database -
        // used for data cleansing prior to data extraction
        public static int SQLExecute(string dbName, string sqlFileName)
        {
            //Tidy up input parameters
            dbName = dbName.Trim();
            sqlFileName = sqlFileName.Trim();
            
            //Fail if dbName or sqlFileName not passed in
            if (dbName == String.Empty)
                throw new ArgumentException("database name required", "dbName");
            if (sqlFileName == String.Empty)
                throw new ArgumentException("SQL file name required", "sqlFileName");

            String sql = System.IO.File.ReadAllText(sqlFileName);
            DBEngineBase db = new SQLiteDBEngine(dbName);
            return db.executeNonQuery(sql);            
        }

        // Run SQL, write output to CSV file
        public static int SQL2Delimited(string dbName, string sqlFileName)
        {
            return SQL2Delimited(dbName, sqlFileName, ',');
        }
        public static int SQL2Delimited(string dbName, string sqlFileName, char delimiter)
        {
            return SQL2Delimited(dbName, sqlFileName, "", delimiter);
        }
        public static int SQL2Delimited(string dbName, string sqlFileName, string outFileName)
        {
            return SQL2Delimited(dbName, sqlFileName, outFileName, ',');
        }
        public static int SQL2Delimited(string dbName, string sqlFileName, string outFileName, char delimiter)
        {
            //Tidy up input parameters
            dbName = dbName.Trim();
            sqlFileName = sqlFileName.Trim();
            outFileName = outFileName.Trim();

            //Fail if dbName or sqlFileName not passed in
            if (dbName == String.Empty)
                throw new ArgumentException("database name required", "dbName");
            if (sqlFileName == String.Empty)
                throw new ArgumentException("SQL file name required", "sqlFileName");

            //If output file name not passed in, generate it from SQL file name
            if (outFileName == String.Empty)
            {
                if (delimiter == ',')
                    outFileName = sqlFileName + ".csv";
                else if (delimiter == '\t')
                    outFileName = sqlFileName + ".tab";
                else
                    outFileName = sqlFileName + ".txt";
            }

            //Do the export
            DataTable dt = SQL2DT(dbName, sqlFileName);
            return DT2Delimited(dt, outFileName, delimiter);
        }

        // Run SQL, write output to XML file
        public static int SQL2XML(string dbName, string sqlFileName)
        {
            return SQL2XML(dbName, sqlFileName, "");
        }
        public static int SQL2XML(string dbName, string sqlFileName, string xmlFileName)
        {
            //Tidy up input parameters
            dbName = dbName.Trim();
            sqlFileName = sqlFileName.Trim();
            xmlFileName = xmlFileName.Trim();

            //Fail if dbName or sqlFileName not passed in
            if (dbName == String.Empty)
                throw new ArgumentException("database name required", "dbName");
            if (sqlFileName == String.Empty)
                throw new ArgumentException("SQL file name required", "sqlFileName");

            //If xmlFileName not passed in, generate it from SQL file name
            if (xmlFileName == String.Empty)
                xmlFileName = sqlFileName + ".xml";

            //Do the export
            DataTable dt = SQL2DT(dbName, sqlFileName);
            return DT2XML(dt, xmlFileName);
        }

        public static DataTable SQL2DT(string dbName, string sqlFileName)
        {
            //Tidy up input parameters
            dbName = dbName.Trim();
            sqlFileName = sqlFileName.Trim();

            //Fail if dbName or sqlFileName not passed in
            if (dbName == String.Empty)
                throw new ArgumentException("database name required", "dbName");
            if (sqlFileName == String.Empty)
                throw new ArgumentException("SQL file name required", "sqlFileName");

            //Do the query
            String sql = System.IO.File.ReadAllText(sqlFileName);
            DBEngineBase db = new SQLiteDBEngine(dbName);
            return db.select(sql);
        }

        // Run SQL, write output to RDF file
        public static int SQL2RDF(string dbName, string sqlFileName, string templateName)
        {
            return SQL2RDF(dbName, sqlFileName, templateName, "");
        }
        public static int SQL2RDF(string dbName, string sqlFileName, string templateName, string rdfFileName)
        {
            return SQL2RDF(dbName, sqlFileName, templateName, rdfFileName, "");
        }
        public static int SQL2RDF(string dbName, string sqlFileName, string templateName, string rdfFileName, string namespaceURI)
        {
            //Tidy up input parameters
            dbName = dbName.Trim();
            sqlFileName = sqlFileName.Trim();
            templateName = templateName.Trim();
            rdfFileName = rdfFileName.Trim();
            namespaceURI = namespaceURI.Trim();
            
            //Fail if dbName, sqlFileName or templateName not passed in
            if (dbName == String.Empty)
                throw new ArgumentException("database name required", "dbName");
            if (sqlFileName == String.Empty)
                throw new ArgumentException("SQL file name required", "sqlFileName");
            if (templateName == String.Empty)
                throw new ArgumentException("template name required", "templateName");

            //If RDF file name not passed in, generate it from SQL file name
            if (rdfFileName == String.Empty)
                rdfFileName = sqlFileName + ".rdf";

            DataTable dt = SQL2DT(dbName, sqlFileName);
            //Convert dt to RDF...

            //String xmlFileName = "temp" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xml";
            String xmlFileName = sqlFileName + "." + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xml";
            int rowCount = DT2XML(dt, xmlFileName);
            XML2RDF(xmlFileName, templateName, rdfFileName, namespaceURI);
            return rowCount;
        }

        // Convert CSV file to XML file
        public static int Delimited2XML(string fileName)
        {
            return Delimited2XML(fileName, "");
        }
        public static int Delimited2XML(string fileName, string xmlFileName)
        {
            return Delimited2XML(fileName, xmlFileName, ',');
        }
        public static int Delimited2XML(string fileName, string xmlFileName, char delimiter)
        {
            return Delimited2XML(fileName, xmlFileName, delimiter, false);
        }
        public static int Delimited2XML(string fileName, bool hasHeader)
        {
            return Delimited2XML(fileName, ',', hasHeader);
        }
        public static int Delimited2XML(string fileName, char delimiter)
        {
            return Delimited2XML(fileName, delimiter, false);
        }
        public static int Delimited2XML(string fileName, string xmlFileName, bool hasHeader)
        {
            return Delimited2XML(fileName, xmlFileName, ',', hasHeader);
        }
        public static int Delimited2XML(string fileName, char delimiter, bool hasHeader)
        {
            return Delimited2XML(fileName, "", delimiter, hasHeader);
        }
        public static int Delimited2XML(string fileName, string xmlFileName, char delimiter, bool hasHeader)
        {
            //Tidy up input parameters
            fileName = fileName.Trim();
            xmlFileName = xmlFileName.Trim();

            //If XML file name not passed in, generate it from CSV file name
            if (xmlFileName == String.Empty)
                xmlFileName = fileName + ".xml";

            DataTable dt = Delimited2DT(fileName, delimiter, hasHeader);
            //dt.TableName = "STELLAR"; //otherwise can't serialize the datatable
            //dt.WriteXml(xmlFileName, XmlWriteMode.WriteSchema); //not right, need STELLAR format...
            return DT2XML(dt, xmlFileName);
        }

        // Convert CSV file to RDF file, according to specified (internal) template
        public static int Delimited2RDF(string fileName, string templateName)
        {
            return Delimited2RDF(fileName, templateName, "");
        }
        public static int Delimited2RDF(string fileName, string templateName, string rdfFileName)
        {
            return Delimited2RDF(fileName, templateName, rdfFileName, false);
        }
        public static int Delimited2RDF(string fileName, string templateName, string rdfFileName, bool hasHeader)
        {
            return Delimited2RDF(fileName, templateName, rdfFileName, "", hasHeader);
        }
        public static int Delimited2RDF(string fileName, string templateName, string rdfFileName, string namespaceURI)
        {
            return Delimited2RDF(fileName, templateName, rdfFileName, namespaceURI, false);
        }
        public static int Delimited2RDF(string fileName, string templateName, string rdfFileName, string namespaceURI, bool hasHeader)
        {
            return Delimited2RDF(fileName, templateName, rdfFileName, namespaceURI, ',', hasHeader);
        }
        public static int Delimited2RDF(string fileName, string templateName, string rdfFileName, string namespaceURI, char delimiter, bool hasHeader)
        {
            //Tidy up input parameters
            fileName = fileName.Trim();
            templateName = templateName.Trim();
            rdfFileName = rdfFileName.Trim();
            namespaceURI = namespaceURI.Trim();

            //Fail if csvFileName or templateName not passed in
            if (fileName == String.Empty)
                throw new ArgumentException("file name required", "fileName");
            if (templateName == String.Empty)
                throw new ArgumentException("template name required", "templateName");

            //If RDF file name not passed in, generate it from CSV file name
            if (rdfFileName == String.Empty)
                rdfFileName = fileName + ".rdf";

            //Name of temporary intermediate XML file
            String xmlFileName = fileName + "." + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xml";
            int rowCount = Delimited2XML(fileName, xmlFileName, delimiter, hasHeader);
            XML2RDF(xmlFileName, templateName, rdfFileName, namespaceURI);
            //Delete the temporary intermediate XML file
            try
            {
                System.IO.File.Delete(xmlFileName);
            }
            catch (Exception ex)
            {
                //silently fail for now, file deletion is only housekeeping..
                //throw new Exception(string.Format("Problem deleting temporary file {0}? {1}", xmlFileName, ex.Message));
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            return rowCount;
        }

        // Convert XML file to RDF file according to specified (internal) template
        public static bool XML2RDF(string xmlFileName, string templateName)
        {
            return XML2RDF(xmlFileName, templateName, "", "");
        }
        public static bool XML2RDF(string xmlFileName, string templateName, string rdfFileName)
        {
            return XML2RDF(xmlFileName, templateName, rdfFileName, "");
        }
        public static bool XML2RDF(string xmlFileName, string templateName, string rdfFileName, string namespaceURI)
        {
            //Tidy up input parameters
            xmlFileName = xmlFileName.Trim();
            templateName = templateName.Trim();
            rdfFileName = rdfFileName.Trim();

            //Fail if xmlFileName or templateName not passed in
            if (xmlFileName == String.Empty)
                throw new ArgumentException("XML file name required", "xmlFileName");
            if (templateName == String.Empty)
                throw new ArgumentException("template name required", "templateName");

            //If RDF file name not passed in, generate it from XML file name
            if (rdfFileName == String.Empty)
                rdfFileName = xmlFileName + ".rdf";

            //Default namespace if not passed in
            namespaceURI = namespaceURI.Trim();
            if (namespaceURI == "")
                namespaceURI = "http://stellar/"; //default

            //using compiled transforms (within STELLAR.Xsl.dll, created using xsltc.exe)
            XslCompiledTransform xslt = new XslCompiledTransform();
            //Create parameters to be passed to the stylesheets
            XsltArgumentList xslArgs = new XsltArgumentList();
            //Extension class containing functions called from within Xsl
            xslArgs.AddExtensionObject("stellar:ext", new XslExtensions());

            xslArgs.AddParam("BASE_URI", "", namespaceURI);

            //Load the specified templateName from STELLAR.Xsl.dll
            Boolean templateExists = false;
            Type[] templateTypes = System.Reflection.Assembly.Load("STELLAR.Xsl").GetTypes();
            foreach (Type t in templateTypes)
            {
                if (t.ToString().ToUpper() == templateName.ToUpper().Trim())
                {
                    xslt.Load(t);
                    templateExists = true;
                    break;
                }
            }
            //Unknown templateName passed in?
            if (!templateExists)
                throw new ArgumentException("unknown template: '" + templateName + "'");

            //Create an XmlTextWriter to handle the output
            XmlTextWriter writer = new XmlTextWriter(rdfFileName, null);
            xslt.Transform(xmlFileName, xslArgs, writer);
            writer.Close();
            return true;
        }
                
        /// <summary>List possible template names (compiled within STELLAR.Xsl.dll)</summary>
        /// <returns>Array of template names</returns>  
        public static String[] templateNames()
        {
            //Get list of all valid templateTypes
            System.Collections.ArrayList a = new System.Collections.ArrayList();
            Type[] templateTypes = System.Reflection.Assembly.Load("STELLAR.Xsl").GetTypes();
            foreach (Type t in templateTypes)
            {
                if (t.IsClass && t.IsPublic)
                    a.Add(t.ToString());
            }
            return ((String[])a.ToArray(typeof(String)));
        }

        public static DataTable Delimited2DT(string fileName)
        {
            return Delimited2DT(fileName, false, -1);
        }
        public static DataTable Delimited2DT(string fileName, int maxRows)
        {
            return Delimited2DT(fileName, false, maxRows);
        }
        public static DataTable Delimited2DT(string fileName, char delimiter)
        {
            return Delimited2DT(fileName, delimiter, -1);
        }
        public static DataTable Delimited2DT(string fileName, bool hasHeader)
        {
            return Delimited2DT(fileName, hasHeader, -1);
        }
        public static DataTable Delimited2DT(string fileName, char delimiter, bool hasHeader)
        {
            return Delimited2DT(fileName, delimiter, hasHeader, -1);
        }
        public static DataTable Delimited2DT(string fileName, bool hasHeader, int maxRows)
        {
            return Delimited2DT(fileName, ',', hasHeader, maxRows);
        }
        public static DataTable Delimited2DT(string fileName, char delimiter, int maxRows)
        {
            return Delimited2DT(fileName, delimiter, false, maxRows);
        }

        /// <summary>Read a delimited data file to a DataTable</summary>
        /// <param name="fileName">The name of the delimited file to read, including absolute or relative path as appropriate</param>
        /// <param name="delimiter">Delimiter character to be used</param>
        /// <param name="hasHeader">Is there a header row containing column names? If not they will be generated automatically</param>
        /// <param name="maxRows">Only read this many rows (useful for testing with larger files)</param>
        /// <returns>The number of records processed</returns>
        /// <exception cref="System.ArgumentException">Throws an exception if delimited file name is not supplied</exception>
        /// <exception cref="System.Exception">Throws an exception if delimited file name does not exist or cannot be accessed</exception>
        public static DataTable Delimited2DT(string fileName, char delimiter, bool hasHeader, int maxRows)
        {
            //Fail if fileName not passed in
            if (fileName == String.Empty)
                throw new ArgumentException("file name required", "fileName");

            //Set up the delimited file reader 
            DelimitedFileEngine<DelimitedRow> engine = new DelimitedFileEngine<DelimitedRow>();
            engine.Options.Delimiter = delimiter.ToString();
            engine.Options.IgnoreEmptyLines = true;            
            //engine.Options.IgnoreCommentedLines = true; 

            DataTable dt = new DataTable();
            long recordCount = 0;
            DelimitedRow[] rows;

            if (!System.IO.File.Exists(fileName))
            {
                throw new Exception(string.Format("Problem finding file {0}?", fileName));
            }
            try
            {
                rows = engine.ReadFile(fileName, maxRows);
                //TODO: Need to allow reading a file that is already open elsewhere
                //System.IO.TextReader tr1 = new System.IO.StreamReader(cmdFileName);
                //System.IO.TextReader tr2 = System.IO.File.OpenText(cmdFileName);
                //rows = engine.ReadStream(tr,maxRows);
                //tr.Close();                
            }
            catch (System.Exception ex)
            {
                throw new Exception(string.Format("Problem reading file {0}? Check the file exists and can be accessed, and is not currently open in another application", fileName), ex);
            }

            foreach (DelimitedRow row in rows)
            {
                //Is this the first row?
                if (recordCount == 0)
                {
                    if (hasHeader)
                    {
                        // First row contains column names    
                        foreach (String s in row.fieldValues)
                        {
                            if (s != null && s.Trim().Length > 0 && !dt.Columns.Contains(s))
                                dt.Columns.Add(getValidColumnName(s), typeof(String));
                            else
                                dt.Columns.Add(getNextColumnName(dt), typeof(String));
                        }
                    }
                    else
                    {
                        // First row just contains values so create default column names for each field
                        //TODO: there's a CHANCE that first row may not have as many values as there are columns
                        //not sure how to guard against that yet...
                        foreach (String s in row.fieldValues)
                        {
                            dt.Columns.Add(getNextColumnName(dt), typeof(String));
                        }
                        dt.Rows.Add(row.fieldValues);
                    }
                }
                else //not first row
                {
                    //still a CHANCE that we have more or less field values than DataTable columns
                    //Ensure that what's being added will match up with DataTable.Columns.Count, however
                    //this may hide errors where a field value contains commas and is incorrectly parsed
                    String[] fieldValues = new String[dt.Columns.Count];

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (i < row.fieldValues.Length)
                            fieldValues[i] = row.fieldValues[i];
                    }
                    //fieldValues.Length should now match DataTable.Columns.Count

                    //Strip leading and trailing quotes if present 
                    //(CSV engine should be doing this but doesn't seem to)                       
                    for (int i = 0; i < fieldValues.Length; i++)
                    {
                        if ((fieldValues[i] != null) && 
                            (fieldValues[i].StartsWith("\"") && 
                            (fieldValues[i].EndsWith("\""))))
                            fieldValues[i] = fieldValues[i].Substring(1, fieldValues[i].Length - 2);

                        //05/09/12 - UNICODE?
                        //if (!fieldValues[i].IsNormalized())
                            //fieldValues[i] = EscapeUnicode(fieldValues[i]);

                    }
                    
                    dt.Rows.Add(fieldValues);
                }
                recordCount++;
                if (maxRows >= 0 && recordCount >= maxRows)
                    break;
            }    
            return dt;
        }

        // 05/09/12 cater for Unicode
        public static string EscapeUnicode(string input)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsSurrogatePair(input, i))
                {
                    builder.Append("\\U" + char.ConvertToUtf32(input, i).ToString("X8"));
                    i++;  //skip the next char     
                }
                else
                {
                    int charVal = char.ConvertToUtf32(input, i);
                    if (charVal > 127)
                    {
                        builder.Append("\\u" + charVal.ToString("X4"));
                    }
                    else
                    {
                        //an ASCII character 
                        builder.Append(input[i]);
                    }
                }
            }

            return builder.ToString();
        }
        //end 05/09/12

        /* 
         * <data>
         *      <row id="1">
         *          <col name="col1">Value1</col>
         *          <col name="col2">Value2</col>
         *      </row>
         *      <row id="2">
         *          <col name="col1">Value3</col>
         *          <col name="col2">Value4</col>
         *      </row>
         * </data>
         */
        /// <summary>Alternative to default XML writing of DataTable - STELLAR specific format
        /// <param name="table">The DataTable to be used</param>
        /// <param name="xmlFileName">The name of the XML file to write, including absolute or relative path as appropriate</param>
        /// <returns>The number of records processed</returns>
        /// <exception cref="System.ArgumentException">Throws an exception if xmlFileName is not supplied</exception>
        public static int DT2XML(DataTable table, String xmlFileName)
        {
            //tidy up input parameters
            xmlFileName = xmlFileName.Trim();

            //Fail if xmlFileName not passed in
            if (xmlFileName == String.Empty)
                throw new ArgumentException("file name required", "xmlFileName");

            //System.IO.StringWriter sw = new StringWriter();
            //XmlTextWriter tw = new XmlTextWriter(xmlFileName, Encoding.UTF8);
            XmlTextWriter tw = new XmlTextWriter(xmlFileName, Encoding.Unicode);
            tw.Formatting = Formatting.Indented;
            tw.WriteStartDocument();
            tw.WriteStartElement("data");
            //tw.WriteAttributeString("source", xmlFileName);
            int rowCount = 0;
            foreach (DataRow dr in table.Rows)
            {
                rowCount++;
                tw.WriteStartElement("row");
                tw.WriteAttributeString("id", rowCount.ToString());

                for (int i = 0; i < dr.ItemArray.Length; i++)
                {
                    tw.WriteStartElement("col");
                    tw.WriteAttributeString("name", table.Columns[i].ColumnName);
                    tw.WriteString(dr[i].ToString().Trim());
                    tw.WriteEndElement(); //col
                }
                tw.WriteEndElement(); //row                
            }
            tw.WriteEndElement(); //data

            tw.Flush();
            tw.Close();
            return rowCount;
        }

        /// <summary>Write the contents of a DataTable to a delimited file</summary>
        /// <param name="table">The DataTable to be used</param>
        /// <param name="fileName">The name of the delimited file to write, including absolute or relative path as appropriate</param>
        /// <param name="delimiter">Delimiter character to be used</param>
        /// <returns>The number of records processed</returns>
        /// <exception cref="System.ArgumentException">Throws an exception if output file name is not supplied</exception>
        public static int DT2Delimited(DataTable table, String fileName, char delimiter)
        {            
            //Tidy up input parameters
            fileName = fileName.Trim();

            //Fail if fileName not passed in
            if (fileName == String.Empty)
                throw new ArgumentException("file name required", "fileName");

            System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName, false);

            //Write delimited header row of column names
            String colNames = "";
            foreach (DataColumn dc in table.Columns)
            {
                String colName = dc.ColumnName;
                //16/01/12 convert any double quotes to single quotes
                colName = colName.Replace('"', '\'');
                //enclose name in double quotes if it CONTAINS the delimiter
                if (colName.Contains(delimiter))
                    colName = "\"" + colName + "\"";

                colNames += colName + delimiter.ToString();
            }
            if (colNames.Length > 0)
            {
                //Remove last delimiter
                colNames = colNames.Remove(colNames.LastIndexOf(delimiter));
                sw.WriteLine(colNames);
            }
            
            //Write delimited record for each row of data
            int rowCount = 0;
            foreach (DataRow dr in table.Rows)
            {
                rowCount++;
                String rowVals = "";
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    String rowVal = dr.ItemArray[i].ToString();
                    //16/01/12 convert any double quotes to single quotes
                    rowVal = rowVal.Replace('"', '\'');
                    //enclose value in quotes if it CONTAINS the delimiter
                    if (rowVal.Contains(delimiter))
                        rowVal = "\"" + rowVal + "\"";

                    rowVals += rowVal + delimiter.ToString();
                }
                if (rowVals.Length > 0)
                {
                    //Remove last delimiter 
                    rowVals = rowVals.Remove(rowVals.LastIndexOf(delimiter));
                    sw.WriteLine(rowVals);
                }
            }
            sw.Close();
            sw.Dispose();
            return rowCount;
        }        

        /// <summary>Run a SQL query against the specified database, convert the output using a StringTemplateGroup file</summary>
        /// <param name="dbName">The name of the database file, including absolute or relative path as appropriate</param>
        /// <param name="sqlFileName">The name of the SQL query file, including absolute or relative path as appropriate</param>
        /// <param name="stgFileName">The name of the StringTemplateGroup file, including absolute or relative path as appropriate</param>
        /// <param name="outFileName">The name of the file to write the output to</param>       
        /// <returns>The number of records processed</returns>
        /// <exception cref="System.ArgumentException">Throws an exception if dbName, sqlFileName or stgFileName are not supplied</exception>
        public static int SQL2STG(string dbName, string sqlFileName, string stgFileName, string outFileName)
        {
            return SQL2STG(dbName, sqlFileName, stgFileName, outFileName, "");
        }
        public static int SQL2STG(string dbName, string sqlFileName, string stgFileName, string outFileName, string optFileName)
        {
            //Tidy up input parameters
            dbName = dbName.Trim();
            sqlFileName = sqlFileName.Trim();
            stgFileName = stgFileName.Trim();
            outFileName = outFileName.Trim();
            optFileName = optFileName.Trim();
            
            //Fail if dbName, sqlFileName or templateName not passed in
            if (dbName == String.Empty)
                throw new ArgumentException("database name required", "dbName");
            if (sqlFileName == String.Empty)
                throw new ArgumentException("SQL file name required", "sqlFileName");
            if (stgFileName == String.Empty)
                throw new ArgumentException("template file name required", "stgFileName");
            // Note optFileName is optional

            //If output file name not passed in, generate it from SQL file name
            if (outFileName == String.Empty)
                outFileName = sqlFileName + ".txt";

            DataTable dt = SQL2DT(dbName, sqlFileName);            
            int rowCount = DT2STG(dt, stgFileName, outFileName, optFileName);
            return rowCount;
        }

        /// <summary>Convert a delimited file using a StringTemplateGroup file</summary>
        /// <param name="fileName">The name of the delimited file, including absolute or relative path as appropriate</param>
        /// <param name="stgFileName">The name of the StringTemplateGroup file, including absolute or relative path as appropriate</param>
        /// <param name="outFileName">The name of the file to write the output to</param> 
        /// <param name="delimiter">Delimiter character for the delimited file</param>       
        /// <returns>The number of records processed</returns>
        public static int Delimited2STG(string fileName, string stgFileName, string outFileName, char delimiter)
        {
            return Delimited2STG(fileName, stgFileName, outFileName, "", true, delimiter);
        }
        public static int Delimited2STG(string fileName, string stgFileName, string outFileName, string optFileName, char delimiter)
        {
            return Delimited2STG(fileName, stgFileName, outFileName, optFileName, true, delimiter);
        }
        public static int Delimited2STG(string fileName, string stgFileName, string outFileName, string optFileName, bool hasHeader, char delimiter)
        {            
            //Tidy up input parameters
            fileName = fileName.Trim();
            stgFileName = stgFileName.Trim();
            outFileName = outFileName.Trim();
            optFileName = optFileName.Trim();

            //If output file name not passed in, generate it from delimited file name
            if (outFileName == String.Empty)
                outFileName = fileName + ".txt";
            DataTable dt = Delimited2DT(fileName, delimiter, true);
            return DT2STG(dt, stgFileName, outFileName, optFileName); 
        }        
        
        /** <summary>
         *  Where to report errors.  All string templates in this group
         *  use this error handler by default.
         *  </summary>
         */
        //class DefaultErrorListener : IStringTemplateErrorListener
        //{
        //    public virtual void Error(string s, Exception e)
        //    {
        //        Console.Error.WriteLine(s);
        //        if (e != null)
        //        {
        //            Console.Error.WriteLine(e.Message);
        //        }
        //    }
        //    public virtual void Warning(string s)
        //    {
        //        Console.Out.WriteLine(s);
        //    }
        //}              

        /// <summary>Convert a System.Data.DataTable using a StringTemplateGroup file</summary>
        /// <param name="table">DataTable to be converted</param>
        /// <param name="stgFileName">The name of the StringTemplateGroup file, including absolute or relative path as appropriate</param>
        /// <param name="outFileName">The name of the file to write the output to</param> 
        /// <param name="optFileName">The name of the file containing options to be passed to templates</param> 
        /// <returns>The number of records processed</returns>     
        /// <exception cref="System.ArgumentException">Throws an exception if stgFileName or outFileName are not supplied</exception>
        public static int DT2STG(DataTable table, String stgFileName, String outFileName)
        {
            return DT2STG(table, stgFileName, outFileName, "");
        }
        public static int DT2STG(DataTable table, String stgFileName, String outFileName, String optFileName)
        {
            //tidy up input parameters
            stgFileName = stgFileName.Trim(); // StringTemplateGroup file
            outFileName = outFileName.Trim(); // Output file
            optFileName = optFileName.Trim(); // Options file (new 20/10/11)

            //Fail if stgFileName not passed in
            if (stgFileName == String.Empty)
                throw new ArgumentException("template file name required", "stgFileName");
            //Fail if outFileName not passed in
            if (outFileName == String.Empty)
                throw new ArgumentException("output file name required", "outFileName");
           
            // Get options - these will be passed to HEADER, RECORD and FOOTER templates
            // Note - Options file is optional - may not be present               
            IDictionary<string, object> options = new Dictionary<string, object>();
            if (optFileName != String.Empty)
            {
                DataTable dtOptions = Delimited2DT(optFileName, true);
                if (dtOptions.Rows.Count > 0)
                {
                    foreach (DataColumn dc in dtOptions.Columns)
                    {
                        String s = dtOptions.Rows[0][dc].ToString();
                        // Ensure any leading and trailing double quotes are removed..
                        s = trimQuotes(s);
                        // Add cleaned value to the array (if not blank)
                        if (s != "")
                        {
                            options[dc.ColumnName.Trim()] = s;
                        }
                    }
                }
            }
            
            //Get full path to the STG file, if not already passed in
            String path = System.IO.Path.GetDirectoryName(stgFileName);
            if (path == "")
                stgFileName = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), stgFileName);
                        
            //Revised for Antlr4...Read the template group from the file, define default delimiters
            TemplateGroupFile stg = new TemplateGroupFile(stgFileName,'$','$');

            //Register renderer for performing Url/Xml Encoding
            stg.RegisterRenderer(typeof(String), new BasicFormatRenderer());

            
            //System.Collections.ArrayList records = new System.Collections.ArrayList();

            //Write the results to the output file
            int rowCount = 0;
            System.IO.StreamWriter sw = null;
            try
            {
                sw = new System.IO.StreamWriter(outFileName, false);

                // If the HEADER template is present, call it and write result to output file 
                if (stg.IsDefined("HEADER"))
                {
                    Template stHeader = stg.GetInstanceOf("HEADER");
                    stHeader.Add("options", options);
                    sw.WriteLine(stHeader.Render());
                }

                foreach (DataRow dr in table.Rows)
                {
                    IDictionary<string, object> record = new Dictionary<string, object>();
                    foreach (DataColumn dc in table.Columns)
                    {
                        String s = dr[dc].ToString();
                        // Ensure any leading and trailing double quotes are removed..
                        s = trimQuotes(s);
                        // Add cleaned value to the array (if not blank)
                        if (s != "")
                        {
                            record[dc.ColumnName.Trim()] = s;
                        }
                    }
                    // If the RECORD template is present, call it and write result to output file 
                    if (stg.IsDefined("RECORD"))
                    {
                        Template stRecord = stg.GetInstanceOf("RECORD");
                        stRecord.Add("data", record);
                        stRecord.Add("options", options);
                        sw.WriteLine(stRecord.Render());
                    }

                    //records.Add(record);
                    rowCount++;
                }

                // If the FOOTER template is present, call it and write result to output file 
                if (stg.IsDefined("FOOTER"))
                {
                    Template stFooter = stg.GetInstanceOf("FOOTER");
                    stFooter.Add("options", options);
                    sw.WriteLine(stFooter.Render());
                }
            }
            catch (Exception ex)
            {
                //worth catching this?
                throw new Exception("Error during conversion: " + ex.Message, ex.InnerException);
            }
            finally
            {
                sw.Close();
                sw.Dispose();
            }           
            return rowCount;
        }       
  
        /// <summary>List the SQLITE database names for a given directory path</summary>
        /// <param name="path">Directory path to be searched</param>
        /// <returns>Array of database file names</returns>       
        public static String[] DBNames(String path)
        {
            return SQLiteDBEngine.getFileNames(path);
        }

        /// <summary>List the tables in a SQLITE database</summary>
        /// <param name="dbName">Database file name</param>
        /// <returns>Array of database table names</returns>  
        /// <exception cref="System.ArgumentException">Throws an exception if dbName is not supplied</exception>
        public static String[] DBTables(String dbName)
        {
            //Tidy up input parameters
            dbName = dbName.Trim();

            //Fail if dbName not passed in
            if (dbName == String.Empty)
                throw new ArgumentException("database name required", "dbName");

            //Get the list of table names for the specified database
            DBEngineBase db = new SQLiteDBEngine(dbName);
            return db.tables();
        }

        /// <summary>List the columns in a SQLITE database table</summary>
        /// <param name="dbName">Database file name</param>
        /// <param name="tableName">Database table name</param>
        /// <returns>Array of database column names</returns>  
        /// <exception cref="System.ArgumentException">Throws an argument exception if dbName or tableName are not supplied</exception>
        public static String[] DBColumns(String dbName, String tableName)
        {
            //Tidy up input parameters
            dbName = dbName.Trim();
            tableName = tableName.Trim();

            //Fail if dbName or tableName not passed in
            if (dbName == String.Empty)
                throw new ArgumentException("database name required", "dbName");
            if (tableName == String.Empty)
                throw new ArgumentException("table name required", "tableName");

            //Get the list of column names for the specified table
            DBEngineBase db = new SQLiteDBEngine(dbName);
            return db.columns(tableName);
        }

        /// <summary>Count the rows in a SQLITE database table</summary>
        /// <param name="dbName">Database file name</param>
        /// <param name="tableName">Database table name</param>
        /// <returns>Row count</returns>  
        /// <exception cref="System.ArgumentException">Throws an exception if dbName or tableName are not supplied</exception>
        public static int DBRowCount(String dbName, String tableName)
        {
            //Tidy up input parameters
            dbName = dbName.Trim();
            tableName = tableName.Trim();

            //Fail if dbName or tableName not passed in
            if (dbName == String.Empty)
                throw new ArgumentException("database name required", "dbName");
            if (tableName == String.Empty)
                throw new ArgumentException("table name required", "tableName");

            //Get the rowcount for the specified table
            DBEngineBase db = new SQLiteDBEngine(dbName);
            return db.count(tableName);
        }
        
        /// <summary>used in CSV2DT to generate next column name when no column header row exists</summary>
        /// <param name="table">existing DataTable</param>
        /// <returns>Generated column name</returns>  
        private static String getNextColumnName(DataTable table)
        {
            int c = 1;
            while (true)
            {
                String h = "Column" + c++;
                if (!table.Columns.Contains(h))
                    return h;
            }
        }

        /// <summary>used in CSV2DT to ensure table/column names are valid - punctuation and spaces replaced with underscores</summary>
        /// <param name="colName">Column name to be checked</param>
        /// <returns>Column name modified as necessary</returns>         
        private static String getValidColumnName(String colName)
        {
            return getValidName(colName);
        }
        private static String getValidTableName(String tblName)
        {
            return getValidName(tblName);
        }
        private static String getValidName(String name)
        {
            //trim, lowercase, replace spaces with underscores
            name = name.Trim().ToLower().Replace(' ', '_');

            //Strip leading and trailing quotes if present
            name = trimQuotes(name);

            //replace any punctuation with underscores
            name = System.Text.RegularExpressions.Regex.Replace(name, @"\p{P}", "_");
            return name;
        }
        private static String trimQuotes(String quotedString)
        {
            String s = quotedString.Trim();
            if((s.StartsWith("\"") && s.EndsWith("\"")) || (s.StartsWith("'") && s.EndsWith("'")))
                s = s.Substring(1, s.Length - 2);
            return s;
        }

        /// <summary>New 04/07/11 - split field values containing nested delimiters into a new table (named as tableName_columnName_split)</summary>
        /// <param name="dbName">Database file name</param>
        /// <param name="tableName">Database table name</param>
        /// <param name="columnName">Name of field containing nested delimiters</param>
        /// <param name="keyColumnName">Name of the key (ID) field from the specified table</param>
        /// <param name="delimiter">Character used as delimiter in the column</param>
        /// <returns>Number of new rows created</returns>  
        public static int DBColumnSplit(string dbName, string tableName, string columnName, string keyColumnName, char delimiter)
        {
            // (re)create the split table as tableName_columnName_split
            String newTableName = tableName.Trim() + "_" + columnName.Trim() + "_split";
            DBEngineBase db = new SQLiteDBEngine(dbName);
            db.executeNonQuery(String.Format("DROP TABLE IF EXISTS \"{0}\";", newTableName));
            db.executeNonQuery(String.Format("CREATE TABLE \"{0}\" (\"{1}\" TEXT COLLATE NOCASE, \"{2}\" TEXT COLLATE NOCASE);", newTableName, keyColumnName, columnName));
            
            //get a DataTable of the values of the ID column and the delimited column
            DataTable dt1 = db.select(String.Format("SELECT {0}, {1} FROM {2} WHERE {1} IS NOT NULL", keyColumnName, columnName, tableName));
            
            // Create a new DataTable (same structure) to hold the split values 
            DataTable dt2 = dt1.Clone();
            dt2.Clear();
            dt2.TableName = newTableName;
            
            //Split the values from dt1 and put them into dt2
            char[] delimiters = new char[] {delimiter};
            foreach(DataRow dr in dt1.Rows)
            {
                String[] splitValues = dr[columnName].ToString().Split(delimiters);
                foreach(String s in splitValues)
                {
                    String[] fieldValues = new String[2];
                    fieldValues[0] = dr[keyColumnName].ToString();
                    fieldValues[1] = s.Trim();
                    if (fieldValues[1] != String.Empty)
                        dt2.Rows.Add(fieldValues);
                }              
            }

            //now insert all the data
            return db.bulkInsert(dt2);             
        }
    }
}
