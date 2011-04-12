using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace STELLAR.Console
{
    class Csv2Stg1ConsoleEngine : ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String csvFileName = System.IO.Path.GetFileName(a["csv"].Trim());
            String path = a["dir"] == null ? "." : a["dir"].Trim();
            String templateName = a["template"].Trim();
            String outFileName = a["out"] == null ? "" : a["out"].Trim();
            this.Out.WriteLine("Convert '{0}' using template '{1}'", csvFileName, templateName);

            try
            {
                //int rowCount = STELLAR.Data.API.Delimited2STG(csvFileName,path, templateName, outFileName, ',');
                int rowCount = STELLAR.Data.API.Delimited2STG(csvFileName, templateName, outFileName, ',');
                
                this.Out.WriteLine("{0} rows converted", rowCount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return ("csv2stg /csv:\"FILE\" /dir:\"PATH\" /template:\"NAME\" [/out:\"FILE\"]");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["csv"] == null)
                return false;
            if (a["dir"] == null)
                return false;
            if (a["template"] == null)
                return false;
            return true;
        }
    }
}
