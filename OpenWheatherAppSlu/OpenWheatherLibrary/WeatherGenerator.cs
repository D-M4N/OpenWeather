using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using OpenWeatherLibrary;
using OpenWeatherApp;
using System.Linq;



namespace OpenWeatherApp
{
    public class WeatherGenerator
    {
        public static async Task<string> GetWeatherDataAsync()
        {
            HttpClient httpClient = new HttpClient();

            string dj = await httpClient.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape,Town&APPID=fd7f81ee5d72a18d06fa8679619f6da7");

            WeatherInfo weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(dj);

            string returnString = string.Empty;/*D-M4N T3ST1NG 4 W3@TH3R*/

            /* WHILE LOOP */

            int index = 0;

            
            /*working*/
            while (index < weatherInfo.weather.Count)
            {
                returnString = weatherInfo.weather[index].main;

                index++;

            }
         
            return returnString;


        }
       
    }
}


