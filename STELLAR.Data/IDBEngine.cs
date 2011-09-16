/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Data.IDBEngine
Summary	: Generic interface for SQL database access
License : http://creativecommons.org/licenses/by/3.0/
================================================================================
History :

12/01/2011  CFB Created classes
================================================================================
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace STELLAR.Data
{
    interface IDBEngine
    {
        // Run SQL query, return DataTable
        DataTable select(String sql);
        // Insert single row, return number of rows affected (0 or 1!)
        int insert(String tableName, IDictionary<string, string> data);
        // Insert multiple rows, return number of rows affected
        int bulkInsert(DataTable dt);
        // Update selected values based on 'where' clause, return number of rows affected
        int update(String tableName, IDictionary<string, string> data, String where);
        // Delete rows based on 'where' clause, return number of rows affected
        int delete(String tableName, String where);
        // Count rows, based on 'where' clause, return number of rows matching
        int count(String tableName, String where);
        // Execute SQL command, return single value 
        String executeScalar(String sql);
        // Execute SQL command, return integer value
        int executeNonQuery(String sql);

        IDbConnection getConnection();
        IDbCommand getCommand(String sql);
        IDbCommand getCommand();
    }
}
