/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandDBNAMES
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
    public class CommandDBNAMES : CommandBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String path = (a["path"] == null ? "." : a["path"].Trim());
            try
            {
                String[] dbNames = STELLAR.Data.API.DBNames(path);
                this.Out.WriteLine("{0} databases found in '{1}'", dbNames.Length, path);
                foreach (String s in dbNames)
                {
                    this.Out.WriteLine(s);
                }                
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("dbNames [/path:\"PATH\"]");
        }        
    }
}

