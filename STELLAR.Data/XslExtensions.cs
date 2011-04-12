using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Data
{
    public class XslExtensions
    {
        //Extension function called by Xsl templates where data is appended to URIs
        //Only done it this way because .NET framework doesn't yet support XSLT 2.0,
        //in which case we could have just used native encode-for-uri function...
        public string URLEncode(string s)
        {
            return System.Web.HttpUtility.UrlEncode(s.Trim().ToLower()); 
        }

        //extension function for Math 'Abs' (working on integer values represented as strings) 
        public string absInt(string s)
        {
            int i = 0;
            int.TryParse(s, out i);
            return Math.Abs(i).ToString();
            
        }
    }
}
