using System;
using System.IO;
using ZirveWinService.Library.Helpers;

namespace ZirveWinService.Service
{
    public class clsMain
    {
        public static bool Init()
        {
            bool blnResult = true;

            try
            {
                string strAppFolder = AppDomain.CurrentDomain.BaseDirectory;
                var strLogFolder = strAppFolder + @"\Logs";

                if (!Directory.Exists(strLogFolder))
                {
                    try
                    {
                        Directory.CreateDirectory(strLogFolder);
                    }
                    catch (Exception excMain)
                    {
                        throw new Exception(string.Format("{0} klasörü oluşturulamadı!", strLogFolder), excMain);
                    }
                }

                LoggerHelper.strLogFolder = strLogFolder;
            }
            catch (Exception ex)
            {
                blnResult = false;
                LoggerHelper.Error($"clsMain.Init() -> Error: {ex}");
            }

            return blnResult;
        }

        public static void DeInit()
        {
            try
            {

            }
            catch (Exception ex)
            {
                LoggerHelper.Error($"clsMain.DeInit() -> Error: {ex}");
            }
        }
    }
}
