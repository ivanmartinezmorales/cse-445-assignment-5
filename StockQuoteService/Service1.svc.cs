using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json.Linq;

namespace StockQuoteService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] getStockData(string ticker)
        {
            var baseAddress = new Uri("https://cloud.iexapis.com");
            var Token = "?token=pk_e96bc5b439e149dc9f58c081bffffc88";

            string url = String.Format(
                "https://cloud.iexapis.com/stable/stock/{0}/quote?token={1}",
                ticker,
                Token);

            List<string> details = new List<string>();
            JObject jsonData;
            using (var client = new System.Net.WebClient())
            {
                jsonData = JObject.Parse(client.DownloadString(url));
            }
            if (jsonData.SelectToken("cod").ToString() == "200")
            {
                Console.WriteLine(jsonData.ToString());

            }

            return details.ToArray();
        }

    }
}
