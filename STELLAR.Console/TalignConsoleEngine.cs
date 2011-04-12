using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    //not used yet.. timelines period alignment functionality imported to stellar
    class TAlignConsoleEngine: ConsoleEngineBase 
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String csvFileName = a["csv"].Trim();
            String refFileName = a["ref"] == null ? "" : a["rdf"].Trim();
            String rdfFileName = a["rdf"] == null ? "" : a["rdf"].Trim();            
            String namespaceURI = a["ns"] == null ? "" : a["ns"].Trim();
            bool hasHeader = a["noheader"] == null ? true : false;
            this.Out.WriteLine("Aligning '{0}' to '{1}'", System.IO.Path.GetFileName(csvFileName), System.IO.Path.GetFileName(refFileName));
            
            try
            {
                TimelineService.TimelineService ts = new TimelineService.TimelineService();
                ts.importNamedPeriods(refFileName);               
                //this.Out.WriteLine("{0} rows converted", rowCount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return ("talign /csv:\"FILE\" /ref:\"FILE\" [/rdf:\"FILE\"] [/ns:\"URI\"]");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["csv"] == null)
                return false;
            if (a["ref"] == null)
                return false;
            return true;   
        }
    }
}
