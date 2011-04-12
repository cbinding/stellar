using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    public class Tab2RdfConsoleEngine : ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String tabFileName = a["tab"].Trim();
            String templateName = a["template"].Trim();
            String rdfFileName = a["rdf"] == null ? "" : a["rdf"].Trim();
            String namespaceURI = a["ns"] == null ? "" : a["ns"].Trim();
            bool hasHeader = a["noheader"] == null ? true : false;
            this.Out.WriteLine("Converting '{0}' to RDF using template '{1}'", System.IO.Path.GetFileName(tabFileName), templateName);

            try
            {
                int rowCount = STELLAR.Data.API.Delimited2RDF(tabFileName, templateName, rdfFileName, namespaceURI, '\t', hasHeader);
                this.Out.WriteLine("{0} rows converted", rowCount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return ("tab2rdf /tab:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"] [/noheader]");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["tab"] == null)
                return false;
            if (a["template"] == null)
                return false;
            return true;
        }
    }
}
