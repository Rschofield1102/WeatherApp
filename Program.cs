using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace CurrentWeather
{
    public class Program
    {
        static void Main(string[] args)
        {


            string key = File.ReadAllText("appsettings.json");

            //parsing your api key to string. storing in variable
            var myKeys = JObject.Parse(key).GetValue("APIKey").ToString(); // is j so convert to string


            Console.WriteLine("Please enter a city to check the current weather.");
            var userInput= Console.ReadLine();
            

            //getting url and inputting your key
            var webUrl = $"https://api.openweathermap.org/data/2.5/weather?q={userInput}&appid={myKeys}&units=imperial";


            //taking the userinput and capatalizing first letter of each word
            userInput= CultureInfo.CurrentCulture.TextInfo.ToTitleCase(userInput.ToLower());

            //using userinput and url to display temp. with degrees class
            Console.WriteLine($"The weather in {userInput} is currently {Degrees.Temp(webUrl)}.");

            Console.ReadKey();

          



        }
    }
}