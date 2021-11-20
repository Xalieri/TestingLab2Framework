using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLab2Framework
{
    public class Expressions
    {
        public double CalculateCommonExp(Func<double, double> CountCos, Func<double, double> CountSin, Func<double, double> CountTan, Func<double, double> LnCount, Func<double, double, double> LogCount, double x)
        {
            if (x <= 0)
            {
                return (((((CountTan(x) / CountTan(x)) + CountSin(x)) + CountTan(x)) * (1 / CountSin(x))) * (1 / CountCos(x)));
            }
            if (x > 0)
            {
                return (((((LogCount(x, 2) - LogCount(x, 2)) * LogCount(x, 10)) / (LogCount(x, 3) / (LogCount(x, 5) * LnCount(x)))) + ((LnCount(x) / (LogCount(x, 10) / LogCount(x, 2))) * LogCount(x, 3))) * ((LogCount(x, 2) * Math.Pow(LogCount(x, 3), 3)) / ((LogCount(x, 10) * LogCount(x, 2)) * Math.Pow(LogCount(x, 5), 2))));
            }
            return 0;
        }
    }
}
