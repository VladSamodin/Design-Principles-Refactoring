﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Models.Rate
{
    public class Rate
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string RateCurrency { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Ask { get; set; }
        public string Bid { get; set; }
    }
}
