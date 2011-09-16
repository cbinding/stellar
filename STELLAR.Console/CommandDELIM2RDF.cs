/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandDELIM2RDF
Summary	: Handler for STELLAR console command
License : http://creativecommons.org/licenses/by/3.0/ 
================================================================================
History :

14/09/2011  CFB Created classes
================================================================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    class CommandDELIM2RDF : CommandBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String dataFileName = a["data"].Trim();
            String templateName = a["template"].Trim();
            String rdfFileName = a["rdf"] == null ? "" : a["rdf"].Trim();
            String namespaceURI = a["ns"] == null ? "" : a["ns"].Trim();
            Char delimiter = a["delimiter"] == null ? ',' : a["delimiter"].Trim().ToCharArray(0, 1).First();
            bool hasHeader = a["noheader"] == null ? true : false;
            this.Out.WriteLine("Converting '{0}' to RDF using template '{1}'", System.IO.Path.GetFileName(dataFileName), templateName);

            try
            {
                int rowCount = STELLAR.Data.API.Delimited2RDF(dataFileName, templateName, rdfFileName, namespaceURI, delimiter, hasHeader);
                this.Out.WriteLine("{0} rows converted", rowCount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return ("delim2rdf /data:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"] [/delimiter:\"CHAR\"] [/noheader]");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["data"] == null)
                return false;
            if (a["template"] == null)
                return false;
            return true;
        }
    }
}
