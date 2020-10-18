using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ServiceModel.Dispatcher;
using System.Linq;

namespace NewsFocusService
{
    public class Service1 : IService1
    {
        private string ApiKey = "9817979e2153476195e572b32724e9d9";
        private string BaseUrl = "https://newsapi.org/v2";


        public string[] NewsFocus(string[] topics)
        {

            List<string> returnUrls = new List<string>();
            List<Root> returnedTopics = new List<Root>();
            using (var client = new System.Net.WebClient())
            {
                foreach (var topic in topics)
                {
                    var response = JsonConvert.
                        DeserializeObject<Root>(
                        client.DownloadString(
                            String.Format(
                                "https://newsapi.org/v2/everything?q={1}&pageSize=5&apiKey={2}", 
                                BaseUrl, 
                                topic, 
                                ApiKey)));

                    if (response.Status == "ok")
                        returnedTopics.Add(response);
                }

                foreach (var item in returnedTopics)
                {
                    try
                    {
                    foreach (var o in item.Articles)
                    {
                        returnUrls.Add(o.Url);
                    }

                    } catch (Exception e)
                    {
                        continue;
                    }

                }
            }

            return returnUrls.ToArray();
        }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Source
    {
        public object Id { get; set; }
        public string Name { get; set; }
    }

    public class Article
    {
        public Source Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Content { get; set; }
    }

    public class Root
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<Article> Articles { get; set; }
    }


}
