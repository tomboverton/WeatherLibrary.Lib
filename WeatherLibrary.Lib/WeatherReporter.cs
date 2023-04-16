using WeatherLibrary.Lib.Models;
namespace WeatherLibrary.Lib
{
    public class WeatherReporter
    {
       public WeatherForecast GetForecast(string _City)
        {
            WeatherForecast forecast = new WeatherForecast();

            switch (_City)
                { 
               case "Plano":
                    forecast.City = _City;
                    forecast.Temperature = "81f";
                    forecast.Conditions = "Cloudy";
                break;
                case "Los Angeles":
                    forecast.City = _City;
                    forecast.Temperature = "72f";
                    forecast.Conditions = "Sunny";
                    break;
                default:
                    forecast.City = "N/A";
                    forecast.Temperature = "0f";
                    forecast.Conditions = "N/A";
                    break;
            }

            return forecast;

        }
    }
}