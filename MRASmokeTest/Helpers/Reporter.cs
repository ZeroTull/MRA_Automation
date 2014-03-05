
using System.IO;
namespace Helpers
{
    public class Reporter
    {
        private static string defaultPath = @"D:\Log.txt";

        public static string Path
        {
            get { return defaultPath; }
            set { defaultPath = value; }
        }

        public static void Log(string log)
        {
            File.AppendAllText(defaultPath, log);
        }
        
    }
}
