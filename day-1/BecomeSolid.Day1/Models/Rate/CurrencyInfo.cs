using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Models.Rate
{

    public class CurrencyInfo
    {
        public Query query { get; set; }
    }

    public class Results
    {
        public Rate[] rate { get; set; }
    }

    public class Rate
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Rate { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Ask { get; set; }
        public string Bid { get; set; }
    }



}
