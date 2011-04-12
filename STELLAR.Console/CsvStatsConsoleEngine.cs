using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    class CsvStatsConsoleEngine : ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String csvFileName = a["csv"].Trim().ToLower();
            bool hasHeader = a["noheader"] == null ? true : false;            

            try
            {
                String stats = STELLAR.Data.Csv.getStats(csvFileName,hasHeader);
                this.Out.WriteLine(stats);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("csvstats /csv:\"FILE\" [/noheader]");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["csv"] == null)
                return false;
            return true;
        }
    }
}
