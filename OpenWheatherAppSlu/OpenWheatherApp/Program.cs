﻿using System;
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

            /* TO CHANGE BACKGROUND COLOR */
            /* Console.BackgroundColor = ConsoleColor.Blue; */

            string capeTown = "FORCAST FOR CAPE TOWN";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (capeTown.Length / 2)) + "}", capeTown));
            Console.WriteLine();
           
            Console.WriteLine("TEMPERATURE: "+dman.Temperature);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();

            Console.WriteLine("HUMIDITY: "+dman.Humidity);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            Console.WriteLine("WEATHER: "+dman.Weather);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();

            /*TO CENTER YOUR TEXT*/
            string tag = "$ 😎 D-M4N 😎 $";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (tag.Length / 2)) + "}", tag));
            Console.Read();
            

        }


    }
}
