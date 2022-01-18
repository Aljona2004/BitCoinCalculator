using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCoinCalculator2
{
    public class bitCoinRates
    {
        public bpi bpi { get; set; }
    }
    public class bpi
    {
        EUR EUR { get; set; }

    }

    public class EUR
    {
        public string code { get; set; }
        public float rate_float { get; set; }
    }
}
