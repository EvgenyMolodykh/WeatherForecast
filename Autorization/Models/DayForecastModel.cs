using Autorization.Enums;

namespace Autorization.Models
{
    public class DayForecastModel
    {
        public DateTime DataTime { get; set; }
        public float MaxTemperature { get; set; }
        public float MinTemperature { get; set; }
        public string Location { get; set; }
        public string Wheather { get; set; }
        public DayOfWeek WeekDay { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public WindDirection WindDirection { get; set; }
        public List<HourlyForecastModel> HourlyForecasts { get; set; }


    }
}
