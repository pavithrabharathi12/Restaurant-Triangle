using Newtonsoft.Json;
using System;

namespace RestaurantTriangle
{
    public static class ZomatoInfo
    {
        const string url = "https://developers.zomato.com/api/v2.1/";
        const string apiKey = "f5c410b28cbc014ce14aa85c3a35ffa2";

        public static RestaurantList GetRestaurants()
        {
            string urlParameters = $"search?q=bangalore&enitity_city=city&apikey={apiKey}";
            var response = APICall.RunAsync<RestaurantList>(url, urlParameters).GetAwaiter().GetResult();
            return response;
        }
    }

    public class RestaurantList
    {
        [JsonProperty("results_found")]
        public int ResultsFound { get; set; }

        [JsonProperty("results_shown")]
        public int ResultsShown { get; set; }

        [JsonProperty("restaurants")]
        public RestaurantRecord[] Restaurants { get; set; }
    }

    public class RestaurantRecord
    {
        [JsonProperty("restaurant")]
        public Restaurant Restaurant { get; set; }
    }

    public class Restaurant
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }

    public class Location
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }
}