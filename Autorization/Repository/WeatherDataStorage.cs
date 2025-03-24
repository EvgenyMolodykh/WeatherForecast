using Autorization.Enums;
using Autorization.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Autorization.Repository
{
    public class WeatherDataStorage
    {
        public static List<DayForecastModel> GetAll()
        {
            List<DayForecastModel> dayForecastModels = new List<DayForecastModel>();
            var random = new Random();
            for (int i = -3; i <= 3; i++)
            {
                DateTime date = DateTime.Now.AddDays(i);

                dayForecastModels.Add(new DayForecastModel
                {
                    DataTime = date,
                    MaxTemperature = random.Next(0, 35),
                    MinTemperature = random.Next(-35, 0),
                    Location = CityStorage.GetRandomCity(),
                    Wheather = WeatherConditionsStorage.WeatherConditionGetRandom(),
                    WeekDay = date.DayOfWeek,
                    Pressure = Math.Round(random.Next(740, 780) + random.NextDouble(), 1), 
                    WindSpeed = Math.Round(random.Next(0, 20) + random.NextDouble(), 1), 
                    WindDirection = WindDirectionStorage.GetRandomWindDirection(),
                    HourlyForecasts = GetHourlyForecastModels()
                });
            }
            return dayForecastModels;
        }

        public static List<HourlyForecastModel> GetHourlyForecastModels()
        {
            var HourlyForecast = new List<HourlyForecastModel>();
            var random = new Random();
            for (var i = 0; i < 24; i++)
            {

                var data = new HourlyForecastModel
                {
                    Time = DateTime.Now.Date.AddHours(i),
                    Temperature = random.Next(-35, 35),
                    ApparentTemperature = random.Next(-35, 35),
                    RelativeHumidity = random.Next(0, 100),
                    SurfasePressure = (float)Math.Round(random.Next(740, 780) + random.NextDouble(), 1),
                    WindSpeed = (float)Math.Round(random.Next(0, 20) + random.NextDouble(), 1),
                    WindDirection = WindDirectionStorage.GetRandomWindDirection().ToString(),
                    Weather = random.Next(0, 5)
                };

                HourlyForecast.Add(data);

            }

            return HourlyForecast;
        }
    }
}
