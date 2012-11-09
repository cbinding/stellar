/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandSQL2STG
Summary	: Handler for STELLAR console command
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

namespace STELLAR.Console
{
    class CommandSQL2STG : CommandBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            //Do the SQL2STG export
            Arguments a = new Arguments(this.Arguments);
            String dbFileName = a["db"].Trim().ToLower();
            String sqlFileName = a["sql"].Trim();
            String stgFileName = a["stg"].Trim();
            String outFileName = a["out"] == null ? "" : a["out"].Trim();
            String optFileName = a["opt"] == null ? "" : a["opt"].Trim();
            this.Out.WriteLine("Running '{0}' against '{1}' using template '{2}'", System.IO.Path.GetFileName(sqlFileName), dbFileName, stgFileName);

            try
            {
                int rowCount = STELLAR.Data.API.SQL2STG(dbFileName, sqlFileName, stgFileName, outFileName, optFileName);
                this.Out.WriteLine("{0} rows exported", rowCount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("sql2stg /db:\"NAME\" /sql:\"FILE\" /stg:\"FILE\" [/out:\"FILE\"] [/opt:\"FILE\"]");
        }

        protected override bool ValidateArguments()
        {

            Arguments a = new Arguments(this.Arguments);
            if (a["db"] == null)
                return false;
            if (a["sql"] == null)
                return false;
            if (a["stg"] == null)
                return false;
            return true;
        }
    }
}
