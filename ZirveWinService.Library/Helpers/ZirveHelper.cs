using Zirve503Lib;
using ZirveWinService.Library.Utils;

namespace ZirveWinService.Library.Helpers
{
    public static class ZirveHelper
    {
        public static Zirve503Islemler GetConnectionObject()
        {
            var ZirveConnect = new Zirve503Islemler();
            ZirveConnect.set_SqlAdi(ConfigurationUtils.SQLHostName);
            ZirveConnect.set_SqlKullaniciAdi(ConfigurationUtils.SQLUserName);
            ZirveConnect.set_SqlSifre(ConfigurationUtils.SQLUserPassword);
            ZirveConnect.set_FirmaKlavuzAdi(ConfigurationUtils.ZirveCompanyGuideName);
            ZirveConnect.set_CalismaYili(ConfigurationUtils.ZirveWorkingYear);
            ZirveConnect.set_MusteriNo(ConfigurationUtils.ZirveCustomerNumber);
            ZirveConnect.SqleBaglan();

            return ZirveConnect;
        }
    }
}