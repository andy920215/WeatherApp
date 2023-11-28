using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public static class ApiService
    {
        public static async Task<Root> GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?llat={0}&lon={1}&appid=a5ee135eadd29719f20eebff2b15ba7f"));
            return JsonConvert.DeserializeObject<Root>(response);
        }
        
        public static async Task<Root> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&lon={1}Taichung&lang=zh_tw&appid=a5ee135eadd29719f20eebff2b15ba7f"));
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
