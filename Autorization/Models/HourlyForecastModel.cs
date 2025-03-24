namespace Autorization.Models
{
    public class HourlyForecastModel
    {
        public DateTime Time { get; set; }

        public float Temperature { get; set; }
        public float ApparentTemperature { get; set; }
        public float RelativeHumidity { get; set; }
        public float SurfasePressure { get; set; }
        public float WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public int Weather { get; set; }
    }
}
