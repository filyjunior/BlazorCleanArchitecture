using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Exceptions
{
    public class WeatherNotFoundException: Exception
    {
        public WeatherNotFoundException(int basketId) : base($"No weather found with id {basketId}")
        {
        }
    }
}
