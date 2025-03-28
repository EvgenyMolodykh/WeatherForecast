﻿namespace BeautifulWeather.Models
{
    public class DayForecastModel
    {
        public string Date { get; set; }
        public string WeekDay { get; set; }
        public float MaxTemperature { get; set; }
        public float MinTemperature { get; set; }
        public float Pressure { get; set; }
        public float WindSpeed { get; set; }
        public WindDirection WindDirection { get; set; }
        public WeatherCodes Weather { get; set; }
        public string Location { get; set; }
        public List<HourlyForecastModel> HourlyForecasts { get; set; }
    }
}
