﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace STELLAR.Console
{
    //New 18/03/2011 - Using StringTemplate group file - user configurable templates 
    class Csv2StgConsoleEngine: ConsoleEngineBase 
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
            String stgFileName = System.IO.Path.GetFileName(a["stg"].Trim());
            String outFileName = a["out"] == null ? "" : a["out"].Trim(); 
            this.Out.WriteLine("Convert '{0}' using template '{1}'", csvFileName, stgFileName);
            
            try 
            {
                int rowCount = STELLAR.Data.API.Delimited2STG(csvFileName, stgFileName, outFileName, ',');
                this.Out.WriteLine("{0} rows converted", rowCount);               
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return ("csv2stg /csv:\"FILE\" /stg:\"FILE\" [/out:\"FILE\"]");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["csv"] == null)
                return false;
            if (a["stg"] == null)
                return false;
            return true;   
        }
    }
}
