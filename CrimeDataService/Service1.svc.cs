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
        public string responseData;
        public string getCrimeData(string lon, string lat)
        {
            getData(lon, lat);
            
            return responseData;
        }

            public async void getData(string lon, string lat)
        {
            
             var baseAddress = new Uri("https://api.crimeometer.com/");

            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {

                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", "Nn3Pm4bq7kt4F2H9sgvT3i2eZCH10RI97Pz6mnr2");

                using (var response = await httpClient.GetAsync($"v1/incidents/raw-data?lat={lat}&lon={lon}&distance=10mi&datetime_ini=2020-01-01&datetime_end=&page="))
                {

                    this.responseData = await response.Content.ReadAsStringAsync();
                }
            }
        }

    }
}
