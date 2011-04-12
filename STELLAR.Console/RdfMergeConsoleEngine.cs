using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Console
{
    class RdfMergeConsoleEngine : ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
            this.showTimings = true;
        }

        protected override void PostProcess()
        {
            Arguments a = new Arguments(this.Arguments);
            String[] rdfFileNames = a["rdf"].Trim().Split(';');
            String outFileName = a["out"].Trim();
            this.Out.WriteLine("Merging {0} files to '{1}'",rdfFileNames.Length.ToString(), System.IO.Path.GetFileName(outFileName));
            this.Out.WriteLine("Please wait, this may take some time...");

            try
            {
                int statementCount = STELLAR.Data.Rdf.merge(rdfFileNames, outFileName);
                this.Out.WriteLine("{0} statements in merged file '{1}'", statementCount,System.IO.Path.GetFileName(outFileName));
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return ("rdfmerge /rdf:\"FILE[;FILE][;FILE]..\" /out:\"FILE\"");
        }

        protected override bool ValidateArguments()
        {
            Arguments a = new Arguments(this.Arguments);
            if (a["rdf"] == null)
                return false;
            if (a["out"] == null)
                return false;
            return true;
        }
    }
}
