namespace Autorization.Repository
{
    public class WeatherConditionsStorage
    {
        private static List<string> weatherConditions = new List<string>() { "North", "South", "East", "West", "North-East", "North-West", "South-East", "South-West" };

        public static string WeatherConditionGetRandom() 
        {
            var randon = new Random();
            int index = randon.Next(0, weatherConditions.Count);
            return weatherConditions.ElementAt(index);
        }

    }
}
