﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    public class DbTablesConsoleEngine : ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String dbName = "" + a["db"].Trim().ToLower(); 
            
            try
            {
                String[] tableNames = STELLAR.Data.API.DBTables(dbName);
                this.Out.WriteLine("{0} tables in database '{1}'", tableNames.Length, dbName);
                foreach (String s in tableNames)
                {
                    this.Out.WriteLine(s);
                }
                /*
                for (int i = 0; i < tableNames.Length; i++)
                {
                    this.Out.WriteLine(tableNames[i]);
                } *. */              
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("dbtables /db:\"NAME\"");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["db"] == null)
                return false;
            return true;
        }
    }
}
