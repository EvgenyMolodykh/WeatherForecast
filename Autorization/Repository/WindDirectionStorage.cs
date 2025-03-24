namespace Autorization.Repository
{
    public class WindDirectionStorage
    {
        public static Enums.WindDirection GetRandomWindDirection()
        {
            var random = new Random();
            Array values = Enum.GetValues(typeof(Enums.WindDirection));
            int index = random.Next(values.Length); 
            return (Enums.WindDirection)values.GetValue(index);
        }
    }
}
