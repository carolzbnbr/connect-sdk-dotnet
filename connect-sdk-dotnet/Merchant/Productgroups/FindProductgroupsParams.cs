/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Productgroups
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/productgroups/find.html">Get payment product groups</a>
    /// </summary>
    public class FindProductgroupsParams : AbstractParamRequest
    {
        public string CountryCode { get; set; } = null;

        public string CurrencyCode { get; set; } = null;

        public string Locale { get; set; } = null;

        public long? Amount { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;

        public IList<string> Hide { get; set; } = null;

        public void AddHide(string value)
        {
            IList<string> hide = Hide;
            if (hide == null)
            {
                hide = new List<string>();
                Hide = hide;
            }
            hide.Add(value);
        }

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            if (CountryCode != null)
            {
                result.Add(new RequestParam("countryCode", CountryCode));
            }
            if (CurrencyCode != null)
            {
                result.Add(new RequestParam("currencyCode", CurrencyCode));
            }
            if (Locale != null)
            {
                result.Add(new RequestParam("locale", Locale));
            }
            if (Amount != null)
            {
                result.Add(new RequestParam("amount", Amount.ToString()));
            }
            if (IsRecurring != null)
            {
                result.Add(new RequestParam("isRecurring", IsRecurring.ToString().ToLower()));
            }
            if (Hide != null)
            {
                foreach (var hideElement in Hide)
                {
                    if (hideElement != null)
                    {
                        result.Add(new RequestParam("hide", hideElement));
                    }
                }
            }
            return result;
        }
    }
}
