using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json.Linq;

namespace WeatherService
{
    public class Service1 : IService1
    {
        private string apiKey = "9c358ce4606b4993c8ae45efda970328";
        public string[] Weather5day(int zipCode)
        {
            string url = String.Format(
                "http://api.openweathermap.org/data/2.5/forecast?zip={0},us&appid={1}", 
                zipCode, 
                apiKey);

            List<string> details = new List<string>();
            JObject jsonData;
            using (var client = new System.Net.WebClient())
            {
                jsonData = JObject.Parse(client.DownloadString(url));
                if (jsonData.SelectToken("cod").ToString() == "200")
                {

                }
            }

            return details.ToArray();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

    }
}
