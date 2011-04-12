using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    class Sql2RdfConsoleEngine: ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            //Do the SQL2RDF export
            Arguments a = new Arguments(this.Arguments);
            String dbFileName = a["db"].Trim().ToLower();
            String sqlFileName = a["sql"].Trim();
            String templateName = a["template"].Trim();            
            String rdfFileName = a["rdf"] == null ? "" : a["rdf"].Trim();
            String namespaceURI = a["ns"] == null ? "" : a["ns"].Trim();
            this.Out.WriteLine("Running '{0}' against '{1}' using template '{2}' producing RDF", System.IO.Path.GetFileName(sqlFileName), dbFileName, templateName);
            
            try
            {
                int rowCount = STELLAR.Data.API.SQL2RDF(dbFileName, sqlFileName, templateName, rdfFileName, namespaceURI);
                this.Out.WriteLine("{0} rows exported", rowCount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("sql2rdf /db:\"NAME\" /sql:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"]");
        }

        protected override bool ValidateArguments()
        {

            Arguments a = new Arguments(this.Arguments);
            if (a["db"] == null)
                return false;
            if (a["sql"] == null)
                return false;
            if (a["template"] == null)
                return false;
            return true;
        }
    }
}
