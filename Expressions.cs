using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLab2Framework
{
    class Expressions
    {
        public double CalculateExp1(Func<double, double> CountCos, Func<double, double> CountSin, Func<double, double> CountTan, double x)
        {
            return (((((CountTan(x) / CountTan(x)) + CountSin(x)) + CountTan(x)) * (1 / CountSin(x))) * (1 / CountCos(x)));
        }

        public double CalculateExp2(Func<double, double> LnCount, double x)
        {
            return (((((Math.Log(x, 2) - Math.Log(x, 2)) * Math.Log10(x)) / (Math.Log(x, 3) / (Math.Log(x, 5) * LnCount(x)))) + ((LnCount(x) / (Math.Log10(x) / Math.Log(x, 2))) * Math.Log(x, 3))) * ((Math.Log(x, 2) * Math.Pow(Math.Log(x, 3), 3)) / ((Math.Log10(x) * Math.Log(x, 2)) * Math.Pow(Math.Log(x, 5), 2))));
        }
    }
}
