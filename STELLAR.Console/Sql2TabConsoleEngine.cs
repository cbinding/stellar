using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    public class Sql2TabConsoleEngine : ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            //Do the SQL2CSV export
            Arguments a = new Arguments(this.Arguments);
            String dbFileName = a["db"].Trim().ToLower();
            String sqlFileName = a["sql"].Trim();
            String outFileName = a["tab"] == null ? "" : a["tab"].Trim();
            this.Out.WriteLine("Running '{0}' against '{1}' producing tab delimited data", System.IO.Path.GetFileName(sqlFileName), dbFileName);

            try
            {
                int rowCount = STELLAR.Data.API.SQL2Delimited(dbFileName, sqlFileName, outFileName, '\t');
                this.Out.WriteLine("{0} rows exported", rowCount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("sql2csv /db:\"NAME\" /sql:\"FILE\" [/csv:\"FILE\"]");
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
