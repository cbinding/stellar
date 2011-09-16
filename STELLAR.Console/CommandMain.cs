/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandMain
Summary	: Main handler for STELLAR console commands
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
using System.Text.RegularExpressions;

namespace STELLAR.Console
{
    public class CommandMain : CommandBase
    {
        public override void Main(string[] args)
        {
            //System.Console.Clear();
            base.Main(args);
            // Application name to be used as command prompt
            //String appName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            ////String appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            
            ////Process commands as they come in
            //string currentLine = this.In.ReadLine();
            //while (currentLine != null)
            //{
            //    this.ProcessLine(currentLine);
            //    this.Out.Write("\n{0}>", appName);                
            //    currentLine = this.In.ReadLine();
            //}            
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
                command = line.Trim();
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
            CommandBase engine = null;
            switch (command.ToLower())
            {                
                case "": break;
                case "exit": System.Console.ResetColor(); Environment.Exit(0);  break;
                case "quit": System.Console.ResetColor(); Environment.Exit(0); break;
                case "help": engine = new CommandHELP(); break;
                case "dbnames": engine = new CommandDBNAMES(); break;
                case "dbtables": engine = new CommandDBTABLES(); break;
                case "dbcolumns": engine = new CommandDBCOLUMNS(); break;
                case "dbrowcount": engine = new CommandDBROWCOUNT(); break;
                case "dbcolsplit": engine = new CommandDBCOLSPLIT(); break; //New 04/07/2011                
                case "sqlexecute": engine = new CommandSQLEXECUTE(); break;
                case "delim2db": engine = new CommandDELIM2DB(); break; //New 14/09/2011
                case "csv2db": engine = new CommandCSV2DB(); break;
                case "tab2db": engine = new CommandTAB2DB(); break;
                case "sql2delim": engine = new CommandSQL2DELIM(); break; //New 14/09/2011
                case "sql2csv": engine = new CommandSQL2CSV(); break;
                case "sql2tab": engine = new CommandSQL2TAB(); break;
                case "sql2xml": engine = new CommandSQL2XML(); break;
                case "sql2rdf": engine = new CommandSQL2RDF(); break;
                case "csv2xml": engine = new CommandCSV2XML(); break;
                case "delim2rdf": engine = new CommandDELIM2RDF(); break; //New 14/09/2011
                case "csv2rdf": engine = new CommandCSV2RDF(); break;
                case "tab2rdf": engine = new CommandTAB2RDF(); break;
                case "xml2rdf": engine = new CommandXML2RDF(); break;
                case "templates": engine = new CommandTEMPLATES(); break;
                case "rdfstats": engine = new CommandRDFSTATS(); break;
                case "csvstats": engine = new CommandCSVSTATS(); break;
                case "rdfmerge": engine = new CommandRDFMERGE(); break;
                case "cmdfile": engine = new CommandMain(); break;
                case "delim2stg": engine = new CommandDELIM2STG(); break; //New 14/09/2011
                case "csv2stg": engine = new CommandCSV2STG(); break; //New 18/03/2011
                case "tab2stg": engine = new CommandTAB2STG(); break; //New 18/08/2011                
                case "sql2stg": engine = new CommandSQL2STG(); break; //New 18/03/2011
                case "datadir": engine = new CommandDATADIR(); break; //New 18/03/2011
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
