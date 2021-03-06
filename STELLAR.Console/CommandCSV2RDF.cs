﻿/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandCSV2RDF
Summary	: Handler for STELLAR console command
License : http://creativecommons.org/licenses/by/3.0/ 
================================================================================
History :

12/01/2011  CFB Created classes
================================================================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    class CommandCSV2RDF: CommandBase 
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
            String templateName = a["template"].Trim();
            String rdfFileName = a["rdf"] == null ? "" : a["rdf"].Trim();            
            String namespaceURI = a["ns"] == null ? "" : a["ns"].Trim();
            bool hasHeader = a["noheader"] == null ? true : false;
            this.Out.WriteLine("Converting '{0}' to RDF using template '{1}'", System.IO.Path.GetFileName(csvFileName), templateName);
            
            try
            {
                int rowCount = STELLAR.Data.API.Delimited2RDF(csvFileName, templateName, rdfFileName, namespaceURI, ',', hasHeader);
                this.Out.WriteLine("{0} rows converted", rowCount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return ("csv2rdf /csv:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"] [/noheader]");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["csv"] == null)
                return false;
            if (a["template"] == null)
                return false;
            return true;   
        }
    }
}
