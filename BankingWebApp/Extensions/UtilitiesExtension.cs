using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace BankingWebApp.Extensions
{
    public static class UtilitiesExtension
    {
        public static void SetData(this ViewDataDictionary dict, string key, object value)
        {
            dict[key] = value;
        }
    }
}
