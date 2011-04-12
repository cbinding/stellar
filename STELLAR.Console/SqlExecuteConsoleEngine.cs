using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    public class SqlExecuteConsoleEngine : ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String dbFileName = a["db"].Trim().ToLower();
            String sqlFileName = a["sql"].Trim();
            this.Out.WriteLine("Running '{0}' against '{1}'", System.IO.Path.GetFileName(sqlFileName), dbFileName);

            try
            {
                int val = STELLAR.Data.API.SQLExecute(dbFileName, sqlFileName);                
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("sqlexecute /db:\"NAME\" /sql:\"FILE\"");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["db"] == null)
                return false;
            if (a["sql"] == null)
                return false;
            return true;
        }
    }
}
