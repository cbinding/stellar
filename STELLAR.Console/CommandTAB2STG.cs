﻿/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandTAB2STG
Summary	: Handler for STELLAR console command
License : http://creativecommons.org/licenses/by/3.0/ 
================================================================================
History :

12/01/2011  CFB Created classes
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
    //New 18/03/2011 - Using StringTemplate group file - user configurable templates 
    class CommandTAB2STG : CommandBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String tabFileName = System.IO.Path.GetFileName(a["tab"].Trim());
            String stgFileName = System.IO.Path.GetFileName(a["stg"].Trim());
            String outFileName = a["out"] == null ? "" : a["out"].Trim();
            String optFileName = a["opt"] == null ? "" : a["opt"].Trim();
            this.Out.WriteLine("Convert '{0}' using template '{1}'", tabFileName, stgFileName);

            try
            {
                int rowCount = STELLAR.Data.API.Delimited2STG(tabFileName, stgFileName, outFileName, optFileName, '\t');
                this.Out.WriteLine("{0} rows converted", rowCount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return ("tab2stg /tab:\"FILE\" /stg:\"FILE\" [/out:\"FILE\"] [/opt:\"FILE\"]");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["tab"] == null)
                return false;
            if (a["stg"] == null)
                return false;
            return true;
        }
    }
}
