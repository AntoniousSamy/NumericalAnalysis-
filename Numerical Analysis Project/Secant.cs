using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Analysis_Project
{
    class Secant
    {
        public int iter { get; set; }
        public double xMins1 { get; set; }
        public double fxMins1 { get; set; }
        public double xi { get; set; }
        public double fxi { get; set; }
        public double error { get; set; }
    }
}
