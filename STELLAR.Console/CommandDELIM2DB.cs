/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.CommandDELIM2DB
Summary	: Handler for STELLAR console command
License : http://creativecommons.org/licenses/by/3.0/ 
================================================================================
History :

14/09/2011  CFB Created classes
================================================================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    public class CommandDELIM2DB : CommandBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            //Do the CSV2DB import
            Arguments a = new Arguments(this.Arguments);
            String dbFileName = a["db"].Trim().ToLower();
            String fileName = a["data"].Trim();
            String tableName = a["table"] == null ? "" : a["table"].Trim().ToLower();
            Char delimiter = a["delimiter"] == null ? ',' : a["delimiter"].Trim().ToCharArray(0,1).First();
            bool hasHeader = a["noheader"] == null ? true : false;
            //new 04/07/11 - append data without recreating the table
            //allows import of data where split across multiple files
            bool append = a["append"] == null ? false : true;

            //char delimiter = a["delimiter"] == null ? ',' : a["delimiter"].PadRight(1,',').ToCharArray(0,1)[0];
            this.Out.WriteLine("Importing file '{0}' to db '{1}'", System.IO.Path.GetFileName(fileName), dbFileName);
            try
            {
                int rowCount = STELLAR.Data.API.Delimited2DB(dbFileName, fileName, tableName, delimiter, hasHeader, append);
                this.Out.WriteLine("{0} rows imported", rowCount);
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("delim2db /db:\"NAME\" /data:\"FILE\" [/delimiter:\"CHAR\"] [/table:\"NAME\"] [/noheader] [/append]");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["db"] == null)
                return false;
            if (a["data"] == null)
                return false;
            return true;
        }
    }
}
