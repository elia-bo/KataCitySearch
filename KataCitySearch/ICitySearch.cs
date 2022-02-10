using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCitySearch
{
    public interface ICitySearch
    {
        IEnumerable<string> SearchInCities(string input);
    }
}
