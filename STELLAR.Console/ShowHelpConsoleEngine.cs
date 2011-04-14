using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    public class ShowHelpConsoleEngine : ConsoleEngineBase 
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
        }

        protected override void PostProcess()
        {  
            this.Out.WriteLine("STELLAR Commands:");
            this.Out.WriteLine("DBNAMES [/path:\"PATH\"]\n\tList databases in a directory");
            this.Out.WriteLine("DBTABLES /db:\"NAME\"\n\tList tables in a database");
            this.Out.WriteLine("DBCOLUMNS /db:\"NAME\" /table:\"NAME\"\n\tList columns in a database table");
            this.Out.WriteLine("DBROWCOUNT /db:\"NAME\" /table:\"NAME\"\n\tCount rows in a database table");
            this.Out.WriteLine("SQLEXECUTE /db:\"NAME\" /sql:\"FILE\"\n\tExecute sql commands against database");
            this.Out.WriteLine("CSV2DB /db:\"NAME\" /csv:\"FILE\" [/table:\"NAME\"] [/noheader]\n\tImport comma delimited file to database table");
            this.Out.WriteLine("TAB2DB /db:\"NAME\" /tab:\"FILE\" [/table:\"NAME\"] [/noheader]\n\tImport tab delimited file to database table");
            this.Out.WriteLine("SQL2CSV /db:\"NAME\" /sql:\"FILE\" [/csv:\"FILE\"]\n\tRun SQL, export result to CSV file");
            this.Out.WriteLine("SQL2TAB /db:\"NAME\" /sql:\"FILE\" [/out:\"FILE\"]\n\tRun SQL, export result to tab delimited file");
            this.Out.WriteLine("SQL2XML /db:\"NAME\" /sql:\"FILE\" [/xml:\"FILE\"]\n\tRun SQL, export result to XML file");
            this.Out.WriteLine("SQL2RDF /db:\"NAME\" /sql:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"]\n\tRun SQL, export result to RDF file (via template)");
            this.Out.WriteLine("CSV2XML /csv:\"FILE\" [/xml:\"FILE\"] [/noheader]\n\tConvert comma delimited file to XML file");
            this.Out.WriteLine("CSV2RDF /csv:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"] [/noheader]\n\tConvert comma delimited file to RDF file (via template)");
            this.Out.WriteLine("TAB2RDF /tab:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"] [/noheader]\n\tConvert tab delimited file to RDF file (via template)");
            this.Out.WriteLine("XML2RDF /xml:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"]\n\tConvert XML file to RDF file (via template)");
            this.Out.WriteLine("TAB2STG /tab:\"FILE\" /stg:\"FILE\" [/out:\"FILE\"]\n\tConvert TAB file using STG template file");
            this.Out.WriteLine("CSV2STG /csv:\"FILE\" /stg:\"FILE\" [/out:\"FILE\"]\n\tConvert CSV file using STG template file");
            this.Out.WriteLine("SQL2STG /db:\"NAME\" /sql:\"FILE\" /stg:\"FILE\" [/out:\"FILE\"]\n\tRun SQL, convert result using STG template file");
            this.Out.WriteLine("TEMPLATES\n\tDisplay list of possible templates to use");
            this.Out.WriteLine("CSVSTATS /csv:\"FILE\" [/noheader]\n\tDisplay statistics for comma delimited file");
            this.Out.WriteLine("RDFSTATS /rdf:\"FILE\"\n\tDisplay statistics for RDF file");
            this.Out.WriteLine("CMDFILE /cmd:\"FILE\"\n\tRun commands from a command file");
            this.Out.WriteLine("DATADIR [/dir:\"PATH\"]\n\tGet or set the current data directory");
            this.Out.WriteLine("RDFMERGE /rdf:\"FILE[;FILE][;FILE]..\" /out:\"FILE\"\n\tMerge multiple RDF files to a single file");
            this.Out.WriteLine("EXIT | QUIT\n\tExit the application");
        }   
    }
}
