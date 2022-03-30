using System.Globalization;

namespace ZirveWinService.Service.Utils
{
    public static class CultureUtils
    {
        public static NumberFormatInfo TurkishNumberFormat = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ",",
            NumberGroupSeparator = ".",
            CurrencyDecimalSeparator = ",",
            CurrencyGroupSeparator = ".",
            CurrencySymbol = "TL",
            CurrencyPositivePattern = 3,
            CurrencyNegativePattern = 8
        };
        public static NumberFormatInfo EnglishNumberFormat = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
            NumberGroupSeparator = ",",
            CurrencyDecimalSeparator = ".",
            CurrencyGroupSeparator = ",",
            CurrencySymbol = "USD",
            CurrencyPositivePattern = 3,
            CurrencyNegativePattern = 8
        };

        public static CultureInfo TurkishCulture
        {
            get
            {
                CultureInfo specificCulture = CultureInfo.CreateSpecificCulture("tr-TR");
                specificCulture.NumberFormat = TurkishNumberFormat;
                return specificCulture;
            }
        }

        public static CultureInfo EnnglishCulture
        {
            get
            {
                CultureInfo specificCulture = CultureInfo.CreateSpecificCulture("en-US");
                specificCulture.NumberFormat = EnglishNumberFormat;
                return specificCulture;
            }
        }
    }
}
