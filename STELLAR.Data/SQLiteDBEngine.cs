using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace STELLAR.Data
{
    public class SQLiteDBEngine : DBEngineBase
    {
        //if no fileName given, generate new DB name based on current time
        public SQLiteDBEngine()
            : base(String.Format("Data Source={0}", DateTime.Now.ToLongDateString() + ".db3")){}
        public SQLiteDBEngine(String fileName)
            : base(String.Format("Data Source={0}", getFileName(fileName))) { }

        public SQLiteDBEngine(IDictionary options) : base(options) { }
       
        public override IDbConnection getConnection()
        {
            return new SQLiteConnection(this.m_connectionString);
        }
        public override IDbCommand getCommand(String sql)
        {
            return new SQLiteCommand(sql);
        }
        public override IDbCommand getCommand()
        {
            return new SQLiteCommand();
        }
        //11/01/11 - functionality moved here from API...
        //Get list of SQLITE database file names 
        public static String[] getFileNames()
        {
            return getFileNames("");
        }
        public static String[] getFileNames(String path)
        {
            path = path.Trim();
            if (path == "")
                path = ".";
            return System.IO.Directory.GetFileSystemEntries(path, "*.db3"); //, System.IO.SearchOption.TopDirectoryOnly); 
        }
        //Get list of table names for the current database
        public override String[] tables()
        {           
            System.Collections.ArrayList a = new System.Collections.ArrayList();
            DataTable tables = this.select("select NAME from SQLITE_MASTER where type='table' order by NAME;");

            foreach (DataRow table in tables.Rows)
            {
                a.Add(table["NAME"].ToString());
            }
            return ((String[])a.ToArray(typeof(String)));
        }
        //Get list of column names for the specified table
        public override String[] columns(String tableName)
        {
            //Tidy up input parameters
            tableName = tableName.Trim();
            
            if (tableName == String.Empty)
                throw new ArgumentException("table name required", "tableName");

            System.Collections.ArrayList a = new System.Collections.ArrayList();
            DataTable columns = this.select("pragma table_info(\"" + tableName + "\"); ");
            foreach (DataRow column in columns.Rows)
            {
                a.Add(column[1].ToString());
            }
            return ((String[])a.ToArray(typeof(String)));
        }
        //Clean up SQLITE database file name, ensure it ends with ".db3" 
        public static String getFileName(String dbName)
        {
            // Tidy up input parameter
            dbName = dbName.Trim().ToLower();
            if (dbName.Length > 0 && !dbName.EndsWith(".db3"))
                dbName += ".db3";
            return (dbName);
        }
    }
}
/*SELECT example:
     * try
{
     db = new SQLiteDatabase();
     DataTable recipe;
     String query = "select NAME \"Name\", DESCRIPTION \"Description\",";
     query += "PREP_TIME \"Prep Time\", COOKING_TIME \"Cooking Time\"";
     query += "from RECIPE;";
     recipe = db.GetDataTable(query);
     // The results can be directly applied to a DataGridView control
     recipeDataGrid.DataSource = recipe;
     /*
     // Or looped through for some other reason
     foreach (DataRow r in recipe.Rows)
     {
          MessageBox.Show(r["Name"].ToString());
          MessageBox.Show(r["Description"].ToString());
          MessageBox.Show(r["Prep Time"].ToString());
          MessageBox.Show(r["Cooking Time"].ToString());
     }
     
}
catch(Exception fail)
{
     String error = "The following error has occurred:\n\n";
     error += fail.Message.ToString() + "\n\n";
     MessageBox.Show(error);
     this.Close();
}

     * */

/* INSERT example:
db = new SQLiteDBEngine();
IDictionary data = new Dictionary();
data.Add("NAME", nameTextBox.Text);
data.Add("DESCRIPTION", descriptionTextBox.Text);
data.Add("PREP_TIME", prepTimeTextBox.Text);
data.Add("COOKING_TIME", cookingTimeTextBox.Text);
data.Add("COOKING_DIRECTIONS", "Placeholder");
try
{
db.insert("RECIPE", data);
}
catch(Exception crap)
{
MessageBox.Show(crap.Message);
}
*/

/*UPDATE example:
 * db = new SQLiteDBEngine();
IDictionary data = new Dictionary();
data.Add("NAME", nameTextBox.Text);
data.Add("DESCRIPTION", descriptionTextBox.Text);
data.Add("PREP_TIME", prepTimeTextBox.Text);
data.Add("COOKING_TIME", cookingTimeTextBox.Text);
try
{
db.update("RECIPE", data, String.Format("RECIPE.ID = {0}", this.RecipeID));
}
catch(Exception crap)
{
MessageBox.Show(crap.Message);
}
*/

/*DELETE example:
 * db = new SQLiteDBEngine();
String recipeID = "12";
db.delete("RECIPE", String.Format("ID = {0}", recipeID));
db.delete("HAS_INGREDIENT", String.Format("ID = {0}", recipeID));
*/
