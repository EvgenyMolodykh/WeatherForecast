using BeautifulWeather.Models;

namespace BeautifulWeather.Storages
{
    public static class WeatherDataStorage
    {
        private static Random random = new Random();
        private static DateTime currentDateTime = DateTime.Now;

        public static List<DayForecastModel> GetAll()
        {
            var weatherDays = new List<DayForecastModel>();

            for (int i = -3; i <= 3; i++)
            {
                var date = currentDateTime.AddDays(i);
                var data = new DayForecastModel()
                {
                    Date = string.Format($"{date:MMMM dd}"),
                    WeekDay = string.Format($"{date:ddd}"),
                    MinTemperature = random.Next(10, 15),
                    MaxTemperature = random.Next(22, 27),
                    Pressure = random.Next(740, 780),
                    WindSpeed = random.Next(0, 12),
                    WindDirection = (WindDirection)Enum.GetValues(typeof(WindDirection)).GetValue(random.Next(0, Enum.GetValues(typeof(WindDirection)).Length)),
                    Weather = (WeatherCodes)Enum.GetValues(typeof(WeatherCodes)).GetValue(random.Next(0, Enum.GetValues(typeof(WeatherCodes)).Length)),
                    Location = "Gavle"
                };
                data.HourlyForecasts = GetHourlyForecasts(data);
                weatherDays.Add(data);
            }

            return weatherDays;
        }

        private static List<HourlyForecastModel> GetHourlyForecasts(DayForecastModel weatherDay)
        {
            var hourlyForecast = new List<HourlyForecastModel>();

            for (int i = 0; i < 24; i++)
            {
                var data = new HourlyForecastModel()
                {
                    Time = currentDateTime.Date.AddHours(i),
                    Temperature = random.Next((int)(weatherDay.MinTemperature * 10), (int)(weatherDay.MaxTemperature * 10)) / 10,
                    ApparentTemperature = random.Next((int)(weatherDay.MinTemperature * 10), (int)(weatherDay.MaxTemperature * 10)) / 10 + random.Next(-5, 5),
                    RelativeHumidity = random.Next(50, 100),
                    SurfacePressure = weatherDay.Pressure + random.Next(-8, 8),
                    WindSpeed = weatherDay.WindSpeed + random.Next(-6, 6),
                    WindDirection = random.Next(0, Enum.GetValues(typeof(WindDirection)).Length),
                    Weather = (WeatherCodes)Enum.GetValues(typeof(WeatherCodes)).GetValue(random.Next(0, Enum.GetValues(typeof(WeatherCodes)).Length)),
                };
                hourlyForecast.Add(data);
            }

            return hourlyForecast;
        }
    }
}
