using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json;

namespace WeatherService
{
    public class Service1 : IService1
    {
        private string apiKey = "9c358ce4606b4993c8ae45efda970328";
        public string[] Weather5day(int zipCode)
        {
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?zip={0},us&appid={1}", zipCode, apiKey);

            Root o = new Root();
            List<string> details = new List<string>();
            using (var client = new System.Net.WebClient())
            {
                var jsonData = client.DownloadString(url);
                o = JsonConvert.DeserializeObject<Root>(jsonData);
                foreach (var item in o.List)
                {
                    details.Add(k2f(item.Main.Temp).ToString());
                }

                foreach (var item in o.List)
                {
                    details.Add(item.Weather.First().Description);
                }
            }

            return details.ToArray();
        }

        private static double k2f(double temp)
        {
            return (temp - 273.15) * (9 / 5) + 32;
        }

    }

    public class Main
    {
        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public int Pressure { get; set; }
        public int SeaLevel { get; set; }
        public int GrndLevel { get; set; }
        public int Humidity { get; set; }
        public double TempKf { get; set; }
    }

    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Clouds
    {
        public int All { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
        public int Deg { get; set; }
    }

    public class Sys
    {
        public string Pod { get; set; }
    }

    public class List
    {
        public int Dt { get; set; }
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
        public Clouds Clouds { get; set; }
        public Wind Wind { get; set; }
        public int Visibility { get; set; }
        public int Pop { get; set; }
        public Sys Sys { get; set; }
        public string DtTxt { get; set; }
    }

    public class Coord
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public int Timezone { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
    }

    public class Root
    {
        public string Cod { get; set; }
        public int Message { get; set; }
        public int Cnt { get; set; }
        public List<List> List { get; set; }
        public City City { get; set; }
    }

}
