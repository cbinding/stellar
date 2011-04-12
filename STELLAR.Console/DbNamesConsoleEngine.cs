using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    public class DbNamesConsoleEngine : ConsoleEngineBase
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

