using System;
using Newtonsoft.Json.Linq;

namespace CurrentWeather
{
	public class Degrees
	{
		public static double Temp(string webUrl)
		{
            var clinet = new HttpClient();
			var response = clinet.GetStringAsync(webUrl).Result;

			var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
			return temp;


            // creating double, using object and parsing to string 
        }
	}
}

