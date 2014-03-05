using Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class Logger
    {
        private static void Log(string str, Severity sev)
        {

            string header = string.Empty;
            switch (sev)
            {
                case Severity.TRACE:
                    header = "TT ##";
                    break;
                case Severity.INFO:
                    header = "II ##";
                    break;
                case Severity.WARNING:
                    header = "WW ##";
                    break;
                case Severity.ERROR:
                    header = "EE ##";
                    break;
                case Severity.STEPIN:
                    header = ">> ##";
                    break;
                case Severity.STEPOUT:
                    header = "<< ##";
                    break;
            }

            Reporter.Log(header + str + Environment.NewLine);
        }

        public static void StepIn(string s)
        {
            Log(s, Severity.STEPIN);
            Debug.WriteLine(s);
        }
        public static void StepOut()
        {
            Log("", Severity.STEPOUT);
        }
        public static void Trace(string s)
        {
            Log(s, Severity.TRACE);
            Debug.WriteLine(s);
        }
        public static void Info(string s)
        {
            Log(s, Severity.INFO);
        }
        public static void Warning(string s)
        {
            Log(s, Severity.WARNING);
        }
        public static void Error(string s)
        {
            Log(s, Severity.ERROR);
        }
        public static void Error(Exception e)
        {
            Log("Error: " + e.Message +"StackTrace: " + e.StackTrace, Severity.ERROR);
        }
        public static void Error(string s, Exception e)
        {
            Log(s, Severity.ERROR);
            Log(e.StackTrace, Severity.ERROR);
        }
        public static void TestDone()
        {
            Reporter.Log("-- ##");
        }
       
    }

    public enum Severity
    {
        TRACE = 0, INFO, WARNING, ERROR, STEPIN, STEPOUT
    };


}
