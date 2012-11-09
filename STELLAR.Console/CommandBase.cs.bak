/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandBase
Summary	: Main base console command functionality
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
    public abstract class CommandBase
    {
        private string[] m_args;        
        protected DateTime started = DateTime.Now;
        protected bool ReadInput = true;
        protected bool showTimings = false;
        protected System.IO.TextReader In = null;
        protected System.IO.TextWriter Out = null;
        protected System.IO.TextWriter Error = null;

        public CommandBase()
        {
            //by default, read from/write to standard streams
            this.In = System.Console.In;
            this.Out = System.Console.Out;
            this.Error = System.Console.Error;
        }
           

        public virtual void Main(string[] args)
        {
            this.m_args = args;
            
            //application name and version display
            String appName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            //String appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            Version appVersion = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
            System.Console.Title = String.Format("{0} v{1}.{2}", appName, appVersion.Major, appVersion.Minor);
            //DateTime startTime = DateTime.Now;  
            //System.Console.WriteLine("{0} started {1}", System.Console.Title, started.ToLongTimeString());
            this.Out.Write("\n{0}>", appName);           

            if (this.ValidateArguments())
            {
                this.PreProcess();
                if (this.ReadInput)
                {
                    string currentLine = this.In.ReadLine();
                    while (currentLine != null)
                    {
                        this.ProcessLine(currentLine);
                        this.Out.Write("\n{0}>", appName);           
                        currentLine = this.In.ReadLine();
                    }
                }
                this.PostProcess();
                if (this.showTimings)
                {
                    TimeSpan elapsed = DateTime.Now.Subtract(this.started);
                    this.Out.WriteLine("[elapsed: {0:00}:{1:00}:{2:00}.{3:000}]", (int)elapsed.TotalHours, elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);
                }
            }
            else
                this.Error.Write("Usage: " + this.Usage());
        }

        public void Main(string[] args,
            System.IO.TextReader In,
            System.IO.TextWriter Out,
            System.IO.TextWriter Error)
        {
            //this version of Main allows alternate streams
            this.In = In;
            this.Out = Out;
            this.Error = Error;
            this.Main(args);
        }

        protected virtual bool ValidateArguments()
        {
            //override this to add custom argument checking
            return true;
        }

        protected virtual string Usage()
        {
            //override this to add custom usage statement 
            return "";
        }

        protected virtual void PreProcess()
        {
            //override this to add custom logic that 
            //executes just before standard in is processed
            return;
        }

        protected virtual void PostProcess()
        {
            //override this to add custom logic that 
            //executes just after standard in is processed
            return;
        }

        protected virtual void ProcessLine(string line)
        {
            //override this to add custom processing 
            //on each line of input
            return;
        }

        protected string[] Arguments
        {
            get { return this.m_args; }
        }        
    }
}