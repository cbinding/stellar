/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Data.SQLiteXmlEncode, STELLAR.Data.SQLiteUrlEncode
Summary	: Extension functions to use inside SQLite SELECT statements
License : http://creativecommons.org/licenses/by/3.0/
================================================================================
History :

24/08/2011  CFB Created classes
================================================================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace STELLAR.Data
{
    // extension function to use inside SQLite SELECT statements - encodes for XML
    [SQLiteFunction(Name = "SQLiteXmlEncode", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class SQLiteXmlEncode : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            return System.Security.SecurityElement.Escape(args[0].ToString().Trim());
        }
    }

    // extension function to use inside SQLite SELECT statements - encodes for URL
    [SQLiteFunction(Name = "SQLiteUrlEncode", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class SQLiteUrlEncode : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            return System.Web.HttpUtility.UrlEncode(args[0].ToString().Trim().ToLower());            
        }
    }

    // extension function to use inside SQLite SELECT statements - find position of string inside another
    // usage: SQLiteCharIndex(exp1, exp2) - search exp2 for exp1 and return start position (1 based)
    // if not found, return 0.
    [SQLiteFunction(Name = "SQLiteCharIndex", Arguments = 2, FuncType = FunctionType.Scalar)]
    public class SQLiteCharIndex : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            return args[1].ToString().IndexOf(args[1].ToString() + 1);            
        }
    }
}
