using System.Configuration;

namespace ZirveWinService.Service.Utils
{
    public class ConfigurationUtils
    {
        //Service Information
        public static string ServiceUrl { get; set; }

        //Zirve Information
        public static string SQLHostName { get; set; }
        public static string SQLUserName { get; set; }
        public static string SQLUserPassword { get; set; }
        public static string ZirveCompanyGuideName { get; set; }
        public static string ZirveWorkingYear { get; set; }
        public static string ZirveCustomerNumber { get; set; }
        
        public static void LoadConfiguration()
        {
            //Service Information
            ServiceUrl = ConfigurationManager.AppSettings["ServiceUrl"].ToString();

            //Zirve Information
            SQLHostName = ConfigurationManager.AppSettings["SQLHostName"].ToString();
            SQLUserName = ConfigurationManager.AppSettings["SQLUserName"].ToString();
            SQLUserPassword = ConfigurationManager.AppSettings["SQLUserPassword"].ToString();
            ZirveCompanyGuideName = ConfigurationManager.AppSettings["ZirveCompanyGuideName"].ToString();
            ZirveWorkingYear = ConfigurationManager.AppSettings["ZirveWorkingYear"].ToString();
            ZirveCustomerNumber = ConfigurationManager.AppSettings["ZirveCustomerNumber"].ToString();
        }
    }
}
