using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace STELLAR.Console
{
    public class StellarMainConsoleEngine : ConsoleEngineBase
    {
        public override void Main(string[] args)
        {
            //System.Console.Clear();

            // Display application name and version in console window title bar
            String appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            
            //Process commands as they come in
            string currentLine = this.In.ReadLine();
            while (currentLine != null)
            {
                this.ProcessLine(currentLine);
                this.Out.Write("\n{0}>", appName);                
                currentLine = this.In.ReadLine();
            }            
        }

        protected override void ProcessLine(string line)
        {
            //Make sure there's something to process and its not a '#' comment (for batch mode)
            if (line == null || line.Trim() == String.Empty || line.Trim().StartsWith("#"))
                return;

            //Parse into command and arguments line
            String command = "";
            String argline = "";

            line = line.Trim();
            int pos = line.IndexOf(' ');
            if (pos == -1)
                command = line;
            else
            {
                command = line.Substring(0, pos).Trim();
                argline = line.Substring(pos + 1).Trim();
            }
            //Console.WriteLine("command: '" + command + "'");
            //Console.WriteLine("argline: '" + argline + "'");

            // Parse the named arguments to a simple string array 
            // string[] args = argline.Split(' '); 
            // CFB 01/04/11 - spaces in file paths passed as arguments tripped it up..            
            // Regular expression is: (/|-{1,2})\w*([:=]((["'][^"']*["'])|([^\s]*)))?
            // Test: /p1:"fred" /p2:"joe and tom" -p3:"josie" --p4="anthony and cleo" /p5:tim /p6              
            // (the version below includes any escape characters necessary to express as C# String)            
            String r = "(/|-{1,2})\\w*([:=](([\"'][^\"']*[\"'])|([^\\s]*)))?";
            Regex parameter = new Regex(r, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            MatchCollection mc = parameter.Matches(argline);
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            foreach (Match m in mc)
            {
                list.Add(m.Value);
            }
            string[] args = (String[])list.ToArray(typeof(String));            
                        
            //Command handlers
            ConsoleEngineBase engine = null;
            switch (command.ToLower())
            {                
                case "": break;
                case "exit": System.Console.ResetColor(); Environment.Exit(0);  break;
                case "quit": System.Console.ResetColor(); Environment.Exit(0); break;
                //case "help": engine = new ShowHelpConsoleEngine(); break;
                case "dbnames": engine = new DbNamesConsoleEngine(); break;
                case "dbtables": engine = new DbTablesConsoleEngine(); break;
                case "dbcolumns": engine = new DbColumnsConsoleEngine(); break;
                case "dbrowcount": engine = new DbRowCountConsoleEngine(); break;
                case "sqlexecute": engine = new SqlExecuteConsoleEngine(); break;
                case "csv2db": engine = new Csv2DbConsoleEngine(); break;
                case "tab2db": engine = new Tab2DbConsoleEngine(); break;
                case "sql2csv": engine = new Sql2CsvConsoleEngine(); break;
                case "sql2tab": engine = new Sql2TabConsoleEngine(); break;
                case "sql2xml": engine = new Sql2XmlConsoleEngine(); break;
                case "sql2rdf": engine = new Sql2RdfConsoleEngine(); break;
                case "csv2xml": engine = new Csv2XmlConsoleEngine(); break;
                case "csv2rdf": engine = new Csv2RdfConsoleEngine(); break;
                case "tab2rdf": engine = new Tab2RdfConsoleEngine(); break;
                case "xml2rdf": engine = new Xml2RdfConsoleEngine(); break;
                case "templates": engine = new TemplatesConsoleEngine(); break;
                case "rdfstats": engine = new RdfStatsConsoleEngine(); break;
                case "csvstats": engine = new CsvStatsConsoleEngine(); break;
                case "rdfmerge": engine = new RdfMergeConsoleEngine(); break;
                case "cmdfile": engine = new StellarMainConsoleEngine(); break;
                case "csv2stg": engine = new Csv2StgConsoleEngine(); break; //New 18/03/2011
                case "sql2stg": engine = new Sql2StgConsoleEngine(); break; //New 18/03/2011
                case "datadir": engine = new DataDirConsoleEngine(); break; //New 18/03/2011
                default:
                    // 01/04/2011 - pass through a DOS command inside STELLAR.Console
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = "cmd";
                    process.StartInfo.Arguments = "/c " + line;
                    process.StartInfo.UseShellExecute = false;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                    process.Dispose();
                    process = null;
                    //this.Out.WriteLine("Unknown STELLAR command '{0}' (type HELP for instructions)", command);
                    break;
            }
            if (engine != null)
            {
                if(engine.GetType() == this.GetType())
                {
                    // If we reach here, command must have been 'cmdfile'
                    Arguments a = new Arguments(args);
                    if (a["cmd"] != null)
                    {
                        String cmdFileName = a["cmd"].Trim().ToLower();
                        System.IO.TextReader tr = null;
                        try
                        {
                            tr = new System.IO.StreamReader(cmdFileName);
                            engine.Main(args, tr, this.Out, this.Error);
                            tr.Close();
                        }
                        catch (Exception ex)
                        {
                            this.Out.WriteLine("Problem reading command file {0}?\n{1}", cmdFileName, ex.Message);
                        }
                        finally
                        {
                            if(tr != null)
                                tr.Close();
                        }
                    }
                }
                else
                    engine.Main(args);
            }
        }
    }
}
