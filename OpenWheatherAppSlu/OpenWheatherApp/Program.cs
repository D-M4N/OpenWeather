using System;
using System.Threading.Tasks;
using OpenWeatherApp;
using OpenWeatherLibrary;


namespace OpenWeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*part1*/
            string weatherString = await WeatherGenerator.GetWeatherDataAsync();

            Console.WriteLine(weatherString);

           

        }


    }
}
