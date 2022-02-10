using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCitySearch
{
    public class CitySearch : ICitySearch
    {
        public IEnumerable<string> SearchInCities(string input)
        {
            if (input == "*") return CitiesDB.Cities;
            if (input.Length < 2) return Enumerable.Empty<string>();
            return CitiesDB.Cities.Where(x => IsContained(input, x));
        }

        private bool IsContained(string input, string city) => city.ToLower().Contains(input.ToLower());
    }
}
