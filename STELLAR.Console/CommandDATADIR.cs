/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandDATADIR
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
    public class CommandDATADIR : CommandBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = false;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String dir = a["dir"] == null ? "" : a["dir"].Trim();

            try
            {
                if (dir != "")
                    System.IO.Directory.SetCurrentDirectory(dir);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
            finally
            {
                this.Out.WriteLine("Data directory is '{0}'", System.IO.Directory.GetCurrentDirectory());
            }
        }

        protected override string Usage()
        {
            return String.Format("datadir [/dir:\"PATH\"]");
        }
    }
}
