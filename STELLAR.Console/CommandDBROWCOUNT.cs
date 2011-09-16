/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandDBROWCOUNT
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
    class CommandDBROWCOUNT : CommandBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String dbName = a["db"].Trim().ToLower();            
            String tablename = a["table"].Trim().ToLower();            

            try
            {
                int rowcount = STELLAR.Data.API.DBRowCount(dbName, tablename);
                this.Out.WriteLine("table '{0}' in database '{1}' contains {2} rows", tablename, dbName, rowcount.ToString());
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("dbrowcount /db:\"NAME\" /table:\"NAME\"");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["db"] == null)
                return false;
            if (a["table"] == null)
                return false;
            return true;
        }
    }
}
