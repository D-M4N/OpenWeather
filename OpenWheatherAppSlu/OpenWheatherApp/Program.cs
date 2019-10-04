using System;
using System.Threading.Tasks;
using OpenWeatherApp;
using OpenWeatherLibrary;



namespace OpenWeatherApp
{
    class Program
    {
       public static async Task Main(string[] args)
        {
            
            var dman = await WeatherGenerator.WeatherDataAsync();

            Console.WriteLine(dman.Temperature);

            Console.WriteLine(dman.Humidity);

            Console.WriteLine(dman.Weather);



        }


    }
}
