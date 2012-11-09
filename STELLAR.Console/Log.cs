/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: Any
Classes	: Log - simple logging functionality for applications
Summary	: Append timestamped messages to daily log file 
          (Log file name format: appname_datestamp.csv e.g. myApp_20110805.csv)
          Usage: Log.Append("message" [,MessageType.Information]);
          Output (CSV) format: date,time,module,function,messagetype,message
License : http://creativecommons.org/licenses/by/3.0/ 
================================================================================
History :

05/08/2011  CFB Created class(es)
26/10/2011  CFB Write to directory of executing app, NOT the working directory
================================================================================
*/
using System;

namespace STELLAR.Console
{
    static class Log
    {
        public enum MessageType 
        {
            Information,
            Error,
            Warning
        }

        // Append timestamped message to daily log file (appname_datestamp.csv)
        // Usage: Log.Append("message" [,MessageType.Information]);
        // Output (CSV) format: date,time,module,function,messagetype,message
        public static bool append(String message)
        {
            return append(message, MessageType.Information);
        }         
        public static bool append(String message, MessageType mt)
        {            
            try
            {                                
                // get name of calling module and function 
                System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace();
                System.Reflection.MethodBase mb = stackTrace.GetFrame(0).GetMethod(); // =this function
                String name = mb.Name;               
                for(int i = 1; i < stackTrace.FrameCount; i++)
                {
                    mb = stackTrace.GetFrame(i).GetMethod();
                    if(mb.Name != name)
                        break;
                }  

                //Build and then write the (CSV formatted) line to todays log file
                String logName = getLogName();                
                String dateStamp = DateTime.Today.ToString("yyyyMMdd");
                String timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");                
                String line = String.Format("{0},{1},{2},{3},{4},\"{5}\"{6}", dateStamp, timeStamp, mb.Module, mb.Name, mt.ToString(), message.Replace(',',';').Replace('"','\''), Environment.NewLine);
                System.IO.File.AppendAllText(logName, line);
            }
            catch(Exception ex)
            {
                // Log errors for testing, but ignore when live
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        // Get the full path + name of the current (dated) log file
        public static string getLogName()
        {
            String dateStamp = DateTime.Today.ToString("yyyyMMdd");
            String appName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            //log is written to directory of executing application, NOT current working directory
            String appDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            String logName = System.IO.Path.Combine(appDir, String.Format("{0}_{1}.csv", appName, dateStamp));
            return logName;     
        }

        //TODO: implementation
        public static bool backup()
        {
            String logName = getLogName();
            // unfinished
            return true; 
        }
    }
}
