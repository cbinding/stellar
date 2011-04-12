using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace STELLAR.Console
{
    //Temp for test only - using PERTAINS functionality to suggest terms from input text...
    public class TermSuggestConsoleEngine : ConsoleEngineBase
    {
        private System.Collections.ArrayList allTerms = null;

        public TermSuggestConsoleEngine(): base()
        {
            //Get vocabulary terms from a text file (primitive..)
            allTerms = new System.Collections.ArrayList();            

            try
            {                
                string line = null;
                System.IO.TextReader tr = new StreamReader("ehg003.txt");
                line = tr.ReadLine();
                while (line != null)
                {                    
                    if (line.Trim() != "")
                    {
                        allTerms.Add(line.Trim());                        
                    }
                    line = tr.ReadLine();
                }
                tr.Close();
                tr = null;
            }
            catch (IOException ex)
            {
                this.Out.WriteLine(ex.ToString());
            }
        }

        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String[] input = (("" + a["input"].Trim()).Split(' '));

            try
            {
                double matchValue = 0;
                string matchTerm = "";

                for (int i = 0; i < input.Length - 1; i++)
                {
                    String inputTerm = input[i] + " " + input[i + 1];

                    foreach (String term in allTerms)
                    {
                        double value = compareStrings(inputTerm, term);
                        if (matchValue < value)
                        {
                            matchValue = value;
                            matchTerm = term;
                        }
                    }
                }
                this.Out.WriteLine("Best match is '{0}' [{1}]", matchTerm, matchValue);                
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("suggest /input:\"TEXT\"");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["input"] == null)
                return false;
            return true;
        }

        // from "how to strike a match"...word/phrase similarity algorithm implementation translated from java  
        // http://www.devarticles.com/c/a/Development-Cycles/How-to-Strike-a-Match/ 
        // used in fine-tuning the ranking of matches coming back from MySQL booean full-text search
        // @return an array of adjacent letter pairs contained in the input string 
        private static String[] letterPairs(String str)
        {
            int numPairs = str.Length - 1;
            String[] pairs = new String[numPairs];
            for (int i = 0; i < numPairs; i++)
            {
                pairs[i] = str.Substring(i, 2);
            }
            return pairs;
        }

        /** @return an ArrayList of 2-character Strings. */
        private static System.Collections.ArrayList wordLetterPairs(String str)
        {
            System.Collections.ArrayList allPairs = new System.Collections.ArrayList();
            // Tokenize the string and put the tokens/words into an array 
            String[] words = str.Split(new char[] { ',', ' ', ':', '-', '&', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            // For each word
            for (int w = 0; w < words.Length; w++)
            {
                // Find the pairs of characters
                String[] pairsInWord = letterPairs(words[w]);
                for (int p = 0; p < pairsInWord.Length; p++)
                {
                    allPairs.Add(pairsInWord[p]);
                }
            }
            return allPairs;
        }
        /** @return lexical similarity value in the range [0,1] */
        public static double compareStrings(String str1, String str2)
        {
            System.Collections.ArrayList pairs1 = wordLetterPairs(str1.ToUpper());
            System.Collections.ArrayList pairs2 = wordLetterPairs(str2.ToUpper());
            int intersection = 0;
            int union = pairs1.Count + pairs2.Count;
            for (int i = 0; i < pairs1.Count; i++)
            {
                Object pair1 = pairs1[i];
                for (int j = 0; j < pairs2.Count; j++)
                {
                    Object pair2 = pairs2[j];
                    if (pair1.Equals(pair2))
                    {
                        intersection++;
                        pairs2.RemoveAt(j);
                        break;
                    }
                }
            }
            return (2.0 * intersection) / union;
        }   /* end "how to strike a match" functions */
    }
}
