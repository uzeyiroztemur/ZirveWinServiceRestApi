using System;
using System.IO;

namespace ZirveWinService.Library.Helpers
{
    public static class LoggerHelper
    {
        public static string strLogFolder { get; set; }

        public static void Debug(string message)
        {
            WriteToFile("Debug", message);
        }

        public static void Error(string message)
        {
            WriteToFile("Error", message);
        }

        public static void Info(string message)
        {
            WriteToFile("Info", message);
        }

        public static void Warning(string message)
        {
            WriteToFile("Warning", message);
        }

        private static void WriteToFile(string type, string sErrMsg)
        {
            try
            {
                var sLogFormat = string.Format("Date: {0} - Type: {1} - Message: {2}", DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString(), type, sErrMsg);

                string sYear = DateTime.Now.Year.ToString("0000");
                string sMonth = DateTime.Now.Month.ToString("00");
                string sDay = DateTime.Now.Day.ToString("00");
                var sErrorTime = sYear + sMonth + sDay;

                string sPathName = strLogFolder + @"\\Trp_Log_" + sErrorTime;
                StreamWriter sw = new StreamWriter(sPathName + ".txt", true);
                sw.WriteLine(sLogFormat);
                sw.Flush();
                sw.Close();
            }
            catch { }
        }
    }
}
