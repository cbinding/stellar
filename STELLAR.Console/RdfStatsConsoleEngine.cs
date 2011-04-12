using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    public class RdfStatsConsoleEngine : ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String rdfFileName = a["rdf"].Trim().ToLower();
            
            try
            {
                String stats = STELLAR.Data.Rdf.getStats(rdfFileName);
                this.Out.WriteLine(stats);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("rdfstats /rdf:\"FILE\"");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["rdf"] == null)
                return false;
            return true;
        }
    }
}
