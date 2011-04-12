using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace STELLAR.Console
{
    class TemplatesConsoleEngine : ConsoleEngineBase
    {
        protected override void PreProcess()
        {
            this.ReadInput = false;
        }

        protected override void PostProcess()
        {            
            try
            {
                String[] templates = STELLAR.Data.API.templateNames();
                this.Out.WriteLine("{0} pre-defined internal templates", templates.Length);
                foreach (String s in templates)
                {
                    this.Out.WriteLine(s);
                }
                String dataDir = Directory.GetCurrentDirectory();
                templates = Directory.GetFiles(dataDir, "*.stg", SearchOption.TopDirectoryOnly);
                this.Out.WriteLine("\n{0} user-defined string template group (*.stg) files\n[{1}]", templates.Length, dataDir);
                foreach (String s in templates)
                {
                    this.Out.WriteLine(Path.GetFileNameWithoutExtension(s));
                }
                /*for (int i = 0; i < templates.Length; i++)
                {
                    this.Out.WriteLine(templates[i]);
                }*/
            }
            catch (Exception ex)
            {
                this.Error.WriteLine(ex.Message);
            }
        }

        protected override string Usage()
        {
            return String.Format("templates");
        }        
    }
}
