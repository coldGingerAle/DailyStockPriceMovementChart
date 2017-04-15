using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyStockPriceMovementChart
{
    public class A
    {
        public string href { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string @class { get; set; }
        public string rel { get; set; }
    }

    public class Results
    {
        public List<A> a { get; set; }
    }

    public class Query
    {
        public int count { get; set; }
        public string created { get; set; }
        public string lang { get; set; }
        public Results results { get; set; }
    }

    public class SP500
    {
        public Query query { get; set; }
    }
}
