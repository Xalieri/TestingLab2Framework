using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLab2Framework
{
    class AlternativeTrigonometry
    {
        public static double Cos(double x)
        {
            double t = 1;
            double sum = 1;
            int p = 0;
            while (Math.Abs(t / sum) > 0)
            {
                p++;
                t = (-t * x * x) / ((2 * p - 1) * (2 * p));
                sum += t;
            }
            return sum;
        }
        public static double Csc(double x)
        {
            return 1 / Math.Sin(x);
        }
        public static double Sec(double x)
        {
            return 1 / Cos(x);
        }
        public static double Ln(double x)
        {

            double count = 1;
            double totalValue = 0;
            double Iterations = 37;
            double z = 1;
            double powe = 1;
            double y;

            while (count <= Iterations)
            {
                for (int i = 0; i < powe; i++)
                {
                    z *= (x - 1) / (x + 1);
                }
                y = (1 / powe) * z;

                totalValue = totalValue + y;
                powe = powe + 2;
                count++;
                z = 1; //Without this line you will have very high powers
            }

            return 2 * totalValue;
        }
    }
}
