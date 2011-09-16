/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandDBCOLSPLIT
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
    class CommandDBCOLSPLIT : CommandBase
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
            String columnname = a["column"].Trim().ToLower();
            String keycolumnname = a["keycolumn"].Trim().ToLower();
            char delimiter = a["delimiter"] == null ? ';' : a["delimiter"].PadRight(1,';').ToCharArray(0,1)[0];
            

            try
            {
                int rowcount = STELLAR.Data.API.DBColumnSplit(dbName, tablename, columnname, keycolumnname, delimiter);
                this.Out.WriteLine("column '{0}' in table '{1}' in database '{2}' split into {3} records", columnname, tablename, dbName, rowcount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("dbcolsplit /db:\"NAME\" /table:\"NAME\" /column:\"COLUMN\" /keycolumn:\"KEYCOLUMN\" [/delimiter:\"DELIMITER\"]");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["db"] == null)
                return false;
            if (a["table"] == null)
                return false; 
            if (a["column"] == null)
                return false;
            if (a["keycolumn"] == null)
                return false;
            return true;
        }
    }
}
