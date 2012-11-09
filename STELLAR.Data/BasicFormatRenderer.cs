using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.StringTemplate;    // external library for StringTemplate
using System.Text.RegularExpressions;

namespace STELLAR.Data
{    
    /// <summary>For specialised rendering of template values</summary>
    /// <returns>Altered string returned to template</returns>      
    /// <example>Usage e.g. $myVal;format="UrlEncode"$</example>
    public class BasicFormatRenderer : IAttributeRenderer
    {
        public String ToString(Object o)
        {
            return o.ToString();
        }
        public String ToString(Object o, String formatName, System.Globalization.CultureInfo ci)
        {
            return (ToString(o, formatName));
        }
        public String ToString(Object o, String formatName)
        {

            String s = (o == null ? "" : o.ToString());

            try
            {
                if (formatName == null)
                    return s;
                else if (formatName.Trim() == "")
                    return s;
                else
                {
                    switch (formatName.Trim().ToUpper())
                    {
                        case "UPPERCASE":
                            return s.ToUpper();
                        case "LOWERCASE":
                            return s.ToLower();
                        case "TRIMSPACE":
                            return s.Trim();
                        case "URLENCODE":
                            return System.Web.HttpUtility.UrlEncode(s.Trim());
                        case "XMLENCODE":
                            return System.Security.SecurityElement.Escape(s.Trim());
                        case "ALIGNPERIOD":
                            return alignPeriod(s); //unused and untested yet...
                        case "MD5ENCODE":
                            return GetHash(s.Trim().ToLower(), HashType.MD5);                              
                        default:
                            return s;
                    }
                }
            }
            catch
            {
                return s;
            }
        }

        // using regexp to pick out year spans and replace with URI(?). 
        // experimental.. To be used in templates via the BasicFormatRenderer
        private static String alignPeriod(String input)
        {
            String s = "";
            input = input.Trim().ToUpper();

            //TODO - regex not right yet
            Regex BCAD = new Regex(@"(\d+)(\D+)(\d+)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            s = BCAD.Replace(s, "$1/$3");

            return s;
        }

        // 06/02/12 - experimental hashing function for creating valid IDs from DB values in user defined 
        // templates, as URL encoding of DB values was causing problems with using PUBBY later on...
        private enum HashType
        {
            MD5,
            SHA1,
            SHA256,
            SHA512
        }
        private static string GetHash(string text, HashType hashType)
        {

            System.Security.Cryptography.HashAlgorithm _algorithm;
            switch (hashType)
            {
                case HashType.MD5:
                    _algorithm = System.Security.Cryptography.MD5.Create();
                    break;
                case HashType.SHA1:
                    _algorithm = System.Security.Cryptography.SHA1.Create();
                    break;
                case HashType.SHA256:
                    _algorithm = System.Security.Cryptography.SHA256.Create();
                    break;
                case HashType.SHA512:
                    _algorithm = System.Security.Cryptography.SHA512.Create();
                    break;
                default:
                    throw new ArgumentException("Invalid hash type", "hashType");
            }
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            byte[] hash = _algorithm.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            _algorithm.Clear();
            return hashString;
        }


    }
}

        

