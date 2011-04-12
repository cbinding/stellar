using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace STELLAR.Data
{
    // Generic interface for SQL database access
    interface IDBEngine
    {
        // Run SQL query, return DataTable
        DataTable select(String sql);
        // Insert row, return number of rows affected (0 or 1)
        int insert(String tableName, IDictionary<string, string> data);
        // Insert multiple rows, return number of rows affected
        int bulkInsert(DataTable dt);
        // Update selected values, return number of rows affected
        int update(String tableName, IDictionary<string, string> data, String where);
        // Delete rows, return number of rows affected
        int delete(String tableName, String where);
        // Count rows, return number of rows
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
