using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorization.Repository
{
    public class CityStorage
    {
        private static List<string> citys = new List<string>() {"New York", "Los Angeles", "Chicago", "Houston", "Phoenix",
            "London", "Paris", "Berlin", "Tokyo", "Sydney" };
        public static List<string> CityGetAll()
        {
            return citys;
        }
        public static string GetRandomCity()
        {
            var random = new Random();
            int index = random.Next(0, citys.Count);
            return citys.ElementAt(index);
        }

    }
}
