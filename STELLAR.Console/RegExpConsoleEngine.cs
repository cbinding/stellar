using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace STELLAR.Console
{
    // test only - not part of STELLAR.Console
    public class RegExpConsoleEngine : ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = false;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String txtFileName = a["txt"].Trim();

            if (!System.IO.File.Exists(txtFileName))
            {
                this.Out.WriteLine("Problem finding file {0}?", txtFileName);
                return;
            }
            System.IO.TextReader tr = null;
            try
            {
                // read the text file
                tr = System.IO.File.OpenText(txtFileName);                
                String doc = tr.ReadToEnd().Trim();
                
                //Split contents by newline
                /*
                Regex line = new Regex(@"\n+", RegexOptions.IgnoreCase | RegexOptions.Compiled);
                string[] lines = line.Split(doc);
                for (int i = 0; i < lines.Length; i++)
                {
                    this.Out.WriteLine("{0}\t{1}", i.ToString(), lines[i]);
                }
                */
                // Split contents by whitespace (consecutive whitespace treated as single)
                /*Regex word = new Regex(@"\s+", RegexOptions.IgnoreCase | RegexOptions.Compiled);
                string[] items = word.Split(doc);
                for(int i = 0; i < items.Length; i++)
                {
                    this.Out.WriteLine("{0}\t{1}", i.ToString(), items[i]);
                }*/

                // how to use custom pattern for identifying words
                Regex word = new Regex(@"[A-Za-z\-]+", RegexOptions.IgnoreCase | RegexOptions.Compiled);
                MatchCollection matches = word.Matches(doc);
                foreach (Match m in matches)
                {
                    this.Out.WriteLine("{0}\t{1}", m.Index, m.Value);
                }

                // Identify position of valid Roman numerals...
                /*
                 * # Roman numerals - ensures valid combinations, up to 4,999
                (?-i:             # turn off case-insensitivity for remainder of the expression
                \b
                (?=[MCDLXVI]+\s)  # look-ahead for 1 or more roman numeral characters                       
                (M{0,4})          # thousands - 0 to 4 M's
                (CM|CD|D?C{0,3})  # hundreds - 900 (CM), 400 (CD), 0-300 (0 to 3 C's), or 500-800 (D, followed by 0 to 3 C's)
                (XC|XL|L?X{0,3})  # tens - 90 (XC), 40 (XL), 0-30 (0 to 3 X's), or 50-80 (L, followed by 0 to 3 X's)
                (IX|IV|V?I{0,3})  # ones - 9 (IX), 4 (IV), 0-3 (0 to 3 I's), or 5-8 (V, followed by 0 to 3 I's)
                )(?=\s)
                */
                this.Out.WriteLine("Roman numerals:");
                Regex numerals = new Regex(
                  "# Roman numerals - ensures valid combinations, up to 4,999\r\n" +
                  "(?-i:               # turn off case-insensitivity for remain" +
                  "der of the expression\r\n\\b\r\n(?=[MCDLXVI]+\\s)  # look-ahead " +
                  "for 1 or more roman numeral characters                      " +
                  " \r\n(M{0,4})                    # thousands - 0 to 4 M's\r\n(CM" +
                  "|CD|D?C{0,3})  # hundreds - 900 (CM), 400 (CD), 0-300 (0 to " +
                  "3 C's), or 500-800 (D, followed by 0 to 3 C's)\r\n(XC|XL|L?X{0" +
                  ",3})    # tens - 90 (XC), 40 (XL), 0-30 (0 to 3 X's), or 50-" +
                  "80 (L, followed by 0 to 3 X's)\r\n(IX|IV|V?I{0,3})         # o" +
                  "nes - 9 (IX), 4 (IV), 0-3 (0 to 3 I's), or 5-8 (V, followed " +
                  "by 0 to 3 I's)\r\n)(?=\\s)\r\n\r\n\r\n\r\n",
                RegexOptions.IgnoreCase
                | RegexOptions.IgnorePatternWhitespace
                );
                MatchCollection matches2 = numerals.Matches(doc);
                foreach (Match m in matches2)
                {
                    this.Out.WriteLine("{0}\t{1}", m.Index, m.Value);
                }
            }
            catch (System.Exception ex)
            {
                this.Out.WriteLine(ex.Message);
            }
            finally
            {
                tr.Close();
                tr.Dispose();
                tr = null;
            }        
        }       
        
        protected override string Usage()
        {
            return String.Format("regexp /txt:\"FILE\"");         
            
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["txt"] == null)
                return false;
            return true;
        }

    }
}
