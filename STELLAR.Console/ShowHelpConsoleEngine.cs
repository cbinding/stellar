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
            switch (this.Arguments[0].Trim().ToLower())
            {
                case "":
                    writeHelp(true);
                    writeHelpDbNames(false);
                    writeHelpDbTables(false);
                    writeHelpDbColumns(false);
                    writeHelpDbRowCount(false);
                    writeHelpSqlExecute(false);
                    writeHelpTab2Db(false);
                    writeHelpCsv2Db(false);
                    writeHelpSql2Csv(false);
                    writeHelpSql2Tab(false);
                    //writeHelpSql2Xml(false);
                    //writeHelpCsv2Xml(false);
                    //writeHelpXml2Rdf(false);
                    writeHelpCsv2Stg(false);    
                    //writeHelpTab2Stg(false);
                    writeHelpSql2Stg(false);
                    writeHelpCsv2Rdf(false);
                    writeHelpTab2Rdf(false);
                    writeHelpSql2Rdf(false);                    
                    writeHelpTemplates(false);
                    writeHelpCsvStats(false);
                    writeHelpRdfStats(false);
                    writeHelpRdfMerge(false);
                    writeHelpCmdFile(false);
                    writeHelpDataDir(false);
                    writeHelpExit(true);   
                    break;
                case "dbnames": writeHelpDbNames(true); break;
                case "dbtables": writeHelpDbTables(true); break;
                case "dbcolumns": writeHelpDbColumns(true); break;
                case "dbrowcount": writeHelpDbRowCount(true); break;
                case "sqlexecute": writeHelpSqlExecute(true); break; 
                case "csv2db": writeHelpCsv2Db(true); break;
                case "tab2db": writeHelpTab2Db(true); break;
                case "sql2csv": writeHelpSql2Csv(true); break;
                case "sql2tab": writeHelpSql2Tab(true); break;
                //case "sql2xml": writeHelpSql2Xml(true); break;
                //case "csv2xml": writeHelpCsv2Xml(true); break;
                //case "xml2rdf": writeHelpXml2Rdf(true); break;   
                case "csv2stg": writeHelpCsv2Stg(true); break; 
                //case "tab2stg": writeHelpTab2Stg(true); break;  
                case "sql2stg": writeHelpSql2Stg(true); break; 
                case "csv2rdf": writeHelpCsv2Rdf(true); break;
                case "tab2rdf": writeHelpTab2Rdf(true); break;
                case "sql2rdf": writeHelpSql2Rdf(true); break;                
                case "templates": writeHelpTemplates(true); break;
                case "csvstats": writeHelpCsvStats(true); break;
                case "rdfstats": writeHelpRdfStats(true); break;
                case "rdfmerge": writeHelpRdfMerge(true); break;
                case "cmdfile": writeHelpCmdFile(true); break;
                case "datadir": writeHelpDataDir(true); break;
                case "exit": writeHelpExit(true); break;
                case "quit": writeHelpExit(true); break;
                default: this.Out.WriteLine("Unknown STELLAR command '{0}'", this.Arguments[0].Trim().ToLower());
                    break;                
            }
        }

        // handle user input of command 'help'      
        private void writeHelp(bool showUsage)
        {
            //this.Out.WriteLine("For information on a particular command type HELP command");
            this.Out.WriteLine("Commands are not case sensitive; parameter order is unimportant");
            this.Out.WriteLine("");
        }

        private void writeHelpExit(bool showUsage)
        {
            this.Out.WriteLine("{0}Exit the application", "EXIT".PadRight(12));
            //Console.WriteLine("Commands are not case sensitive and parameter order is unimportant"); 
        }

        // handle user input of command 'help dbNames' 
        private void writeHelpDbNames(bool showUsage)
        {
            this.Out.WriteLine("{0}List databases in a directory", "DBNAMES".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: DBNAMES [/path:\"PATH\"]");
            }
        }

        // handle user input of command 'help dbtables' 
        private void writeHelpDbTables(bool showUsage)
        {
            this.Out.WriteLine("{0}List tables in a database","DBTABLES".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: DBTABLES /db:\"NAME\"");
            }            
        }

        // handle user input of command 'help dbcolumns' 
        private void writeHelpDbColumns(bool showUsage)
        {
            this.Out.WriteLine("{0}List columns in a database table","DBCOLUMNS".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: DBCOLUMNS /db:\"NAME\" /table:\"NAME\"");
            }
        }

        // handle user input of command 'help dbrowcount' 
        private void writeHelpDbRowCount(bool showUsage)
        {
            this.Out.WriteLine("{0}Count rows in a database table","DBROWCOUNT".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: DBROWCOUNT /db:\"NAME\" /table:\"NAME\"");
            }
        }

        // handle user input of command 'help sqlexecute' 
        private void writeHelpSqlExecute(bool showUsage)
        {
            this.Out.WriteLine("{0}Execute sql commands against database", "SQLEXECUTE".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: SQLEXECUTE /db:\"NAME\" /sql:\"FILE\"");
            }
        }

        // handle user input of command 'help csv2db' 
        private void writeHelpCsv2Db(bool showUsage)
        {
            this.Out.WriteLine("{0}Import comma delimited file to database table", "CSV2DB".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: CSV2DB /db:\"NAME\" /csv:\"FILE\" [/table:\"NAME\"] [/noheader]");
            }
        }

        // handle user input of command 'help tab2db' 
        private void writeHelpTab2Db(bool showUsage)
        {
            this.Out.WriteLine("{0}Import tab delimited file to database table", "TAB2DB".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: TAB2DB /db:\"NAME\" /tab:\"FILE\" [/table:\"NAME\"] [/noheader]");
            }
        }

        // handle user input of command 'help sql2csv' 
        private void writeHelpSql2Csv(bool showUsage)
        {
            this.Out.WriteLine("{0}Run SQL, export result to CSV file", "SQL2CSV".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: SQL2CSV /db:\"NAME\" /sql:\"FILE\" [/csv:\"FILE\"]");
            }
        }        

        // handle user input of command 'help sql2tab' 
        private void writeHelpSql2Tab(bool showUsage)
        {
            this.Out.WriteLine("{0}Run SQL, export result to tab delimited file", "SQL2TAB".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: SQL2TAB /db:\"NAME\" /sql:\"FILE\" [/out:\"FILE\"]");
            }
        }

        // handle user input of command 'help sql2xml' 
        private void writeHelpSql2Xml(bool showUsage)
        {
            this.Out.WriteLine("{0}Run SQL, export result to XML file","SQL2XML".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: SQL2XML /db:\"NAME\" /sql:\"FILE\" [/xml:\"FILE\"]");
            }
        }

        // handle user input of command 'help sql2rdf' 
        private void writeHelpSql2Rdf(bool showUsage)
        {
            this.Out.WriteLine("{0}Run SQL, export result to RDF file (via template)","SQL2RDF".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: SQL2RDF /db:\"NAME\" /sql:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"]");
            }
        }

        // handle user input of command 'help csv2xml' 
        private void writeHelpCsv2Xml(bool showUsage)
        {
            this.Out.WriteLine("{0}Convert comma delimited file to XML file","CSV2XML".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: CSV2XML /csv:\"FILE\" [/xml:\"FILE\"] [/noheader]");
            }
        }       

        // handle user input of command 'help csv2rdf'
        private void writeHelpCsv2Rdf(bool showUsage)
        {
            this.Out.WriteLine("{0}Convert comma delimited file to RDF file (via template)","CSV2RDF".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: CSV2RDF /csv:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"] [/noheader]");
            }
        }

        // handle user input of command 'help tab2rdf'
        private void writeHelpTab2Rdf(bool showUsage)
        {
            this.Out.WriteLine("{0}Convert tab delimited file to RDF file (via template)", "TAB2RDF".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: TAB2RDF /tab:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"] [/noheader]");
            }
        }


        // handle user input of command 'help xml2rdf'
        private void writeHelpXml2Rdf(bool showUsage)
        {
            this.Out.WriteLine("{0}Convert XML file to RDF file (via template)","XML2RDF".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: XML2RDF /xml:\"FILE\" /template:\"NAME\" [/rdf:\"FILE\"] [/ns:\"URI\"]");
            }
        }

        // handle user input of command 'help tab2stg'
        private void writeHelpTab2Stg(bool showUsage)
        {
            this.Out.WriteLine("{0}Convert TAB file using STG template file", "TAB2STG".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: TAB2STG /tab:\"FILE\" /stg:\"FILE\" [/out:\"FILE\"]");
            }
        }

        // handle user input of command 'help csv2stg'
        private void writeHelpCsv2Stg(bool showUsage)
        {
            this.Out.WriteLine("{0}Convert CSV file using STG template file", "CSV2STG".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: CSV2STG /csv:\"FILE\" /stg:\"FILE\" [/out:\"FILE\"]");
            }
        }

        // handle user input of command 'help csv2stg'
        private void writeHelpSql2Stg(bool showUsage)
        {
            this.Out.WriteLine("{0}Run SQL, convert result using STG template file", "SQL2STG".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: SQL2STG /db:\"NAME\" /sql:\"FILE\" /stg:\"FILE\" [/out:\"FILE\"]");
            }
        }

        // handle user input of command 'help templates'
        private void writeHelpTemplates(bool showUsage)
        {
            this.Out.WriteLine("{0}Display list of possible templates to use", "TEMPLATES".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: TEMPLATES");
            }
        }

        // handle user input of command 'help csvstats'
        private void writeHelpCsvStats(bool showUsage)
        {
            this.Out.WriteLine("{0}Display statistics for comma delimited file", "CSVSTATS".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: CSVSTATS /csv:\"FILE\" [/noheader]");
            }
        }

        // handle user input of command 'help rdfstats'
        private void writeHelpRdfStats(bool showUsage)
        {
            this.Out.WriteLine("{0}Display statistics for RDF file","RDFSTATS".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: RDFSTATS /rdf:\"FILE\"");
            }
        }

        // handle user input of command 'help cmdfile'
        private void writeHelpCmdFile(bool showUsage)
        {
            this.Out.WriteLine("{0}Run commands from a command file", "CMDFILE".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: CMDFILE /cmd:\"FILE\"");
            }
        }

        // handle user input of command 'help datadir'
        private void writeHelpDataDir(bool showUsage)
        {
            this.Out.WriteLine("{0}Get or set the current data directory", "DATADIR".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: DATADIR [/dir:\"PATH\"]");
            }
        }


        // handle user input of command 'help rdfmerge'
        private void writeHelpRdfMerge(bool showUsage)
        {
            this.Out.WriteLine("{0}Merge multiple RDF files to a single file", "RDFMERGE".PadRight(12));
            if (showUsage)
            {
                this.Out.WriteLine("Usage: RDFMERGE /rdf:\"FILE[;FILE][;FILE]..\" /out:\"FILE\"");
            }
        }
    }
}
