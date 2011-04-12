using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    public class DbColumnsConsoleEngine : ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String dbName = a["db"].Trim().ToLower();             
            String tablename = a["table"].Trim().ToLower(); 
            
            try
            {
                String[] columnNames = STELLAR.Data.API.DBColumns(dbName, tablename);
                this.Out.WriteLine("{0} columns in table '{1}' in database '{2}'", columnNames.Length, tablename, dbName);
                foreach (String s in columnNames)
                {
                    this.Out.WriteLine(s);
                }
                /*for (int i = 0; i < columnNames.Length; i++)
                {
                    this.Out.WriteLine(columnNames[i]);
                }    */           
            }
            catch (Exception ex) 
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("dbcolumns /db:\"NAME\" /table:\"NAME\"");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["db"] == null)
                return false;
            if (a["table"] == null)
                return false;
            return true;
        }
    }
}
