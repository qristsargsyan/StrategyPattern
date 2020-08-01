using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class TravelStrategy
    {
        private IStrategy _strategy;

        public TravelStrategy(IStrategy chosenstrategy)
        {
            _strategy = chosenstrategy;
        }

        public void GetTravelTime(string source,string destination)
        {
            string result = _strategy.GetTravelTime(source, destination);
            Console.WriteLine(result);
        }
    }
}
