/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Console.Program
Summary	: Main entry point for STELLAR.Console application
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
    class Program
    {
        static void Main(string[] args)
        {
            //String appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            //Version appVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            //System.Console.Title = String.Format("{0} v{1}.{2}", appName, appVersion.Major, appVersion.Minor);

            // Change colors to distinguish STELLAR from normal console
            System.Console.BackgroundColor = ConsoleColor.DarkBlue;
            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.Clear();

            System.Console.Out.WriteLine("(type HELP for commands)");
            //System.Console.Out.Write("\n{0}>", appName);

            CommandBase engine = new CommandMain();

            engine.Main(args);
            System.Console.ResetColor();
        }       
    }
}
