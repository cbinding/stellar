/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandDELIM2STG
Summary	: Handler for STELLAR console command
License : http://creativecommons.org/licenses/by/3.0/ 
================================================================================
History :

14/09/2011  CFB Created classes
21/10/2011  CFB Added functionality to pass options file data to STG templates
================================================================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace STELLAR.Console
{
    class CommandDELIM2STG : CommandBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String dataFileName = System.IO.Path.GetFileName(a["data"].Trim());
            String stgFileName = System.IO.Path.GetFileName(a["stg"].Trim());
            String outFileName = a["out"] == null ? "" : a["out"].Trim();
            String optFileName = a["opt"] == null ? "" : a["opt"].Trim();
            Char delimiter = a["delimiter"] == null ? ',' : a["delimiter"].Trim().ToCharArray(0, 1).First();            
            this.Out.WriteLine("Convert '{0}' using template '{1}'", dataFileName, stgFileName);

            try
            {
                int rowCount = STELLAR.Data.API.Delimited2STG(dataFileName, stgFileName, outFileName, optFileName, delimiter);
                this.Out.WriteLine("{0} rows converted", rowCount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return ("delim2stg /data:\"FILE\" /stg:\"FILE\" [/out:\"FILE\"] [/opt:\"FILE\"] [/delimiter:\"CHAR\"]");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["data"] == null)
                return false;
            if (a["stg"] == null)
                return false;
            return true;
        }
    }
}
