using System;
using System.Net.Http;

using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CrimeDataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        
        public int getCrimeData(double lon, double lat)
        {
            // Another API KEY
            // qOrZ6nWzlRHJjZ0xnM7uyejSvM066s1HIPWoMF5f
            string url = "https://api.usa.gov/crime/fbi/sapi/api/nibrs/rape/offender/states/AZ/count?API_KEY=iiHnOKfno2Mgkt5AynpvPpUQTEyxE77jo1RU8PIv";

            List<string> details = new List<string>();
            JObject jsonData;
            using (var client = new System.Net.WebClient())
            {
                jsonData = JObject.Parse(client.DownloadString(url));
            }
            string s = jsonData["data"][0]["value"].ToString();
            
            return Int32.Parse(s);
        }

         

    }
}
