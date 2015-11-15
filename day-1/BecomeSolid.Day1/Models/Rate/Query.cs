using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Models.Rate
{
    public class Query
    {
        public int count { get; set; }
        public DateTime created { get; set; }
        public string lang { get; set; }
        public Results results { get; set; }
    }
}
