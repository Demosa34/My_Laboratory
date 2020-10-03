using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCHelper
{
    class ParameterRadius
    {
        public string name;
        public double value;
       
       // public Parameter (string n, double v) { name = n; value = v; }

        public ParameterRadius(string name,double value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
