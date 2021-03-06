using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLab2Framework
{
    public class AlternativeTrigonometry
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
        public static double Sin(double x)
        {
            if (x > 0)
            {
                int kOfPi = 0;
                for (double i = 0; i < x; i += Math.PI)
                {
                    kOfPi = Convert.ToInt32(i/ Math.PI); 
                }
                if(kOfPi % 2 == 0)
                {
                    return Math.Sqrt(1 - Math.Pow(Cos(x), 2));
                }
                else
                {
                    return Math.Sqrt(1 - Math.Pow(Cos(x), 2)) * -1;
                }
            }
            if (x < 0)
            {
                int kOfPi = 0;
                for (double i = 0; i > x; i -= Math.PI)
                {
                    kOfPi = Convert.ToInt32(i/ Math.PI);
                }
                if (kOfPi % 2 == 0)
                {
                    return Math.Sqrt(1 - Math.Pow(Cos(x), 2)) * -1;
                }
                else
                {
                    return Math.Sqrt(1 - Math.Pow(Cos(x), 2));
                }
            }


            //if (x > Math.PI || x < -Math.PI)
            //{
            //    if (x > 0)
            //    {
            //        return Math.Sqrt(1 - Math.Pow(Cos(x), 2));
            //    }
            //    if (x < 0)
            //    {
            //        return Math.Sqrt(1 - Math.Pow(Cos(x), 2)) * -1;
            //    }
            //}
            //else
            //{
            //    return Math.Sqrt(1 - Math.Pow(Cos(x), 2));
            //}
            return 0;
        }
        public static double Tan(double x)
        {
            return Sin(x) / Cos(x);
        }
        public static double Csc(double x)
        {
            return 1 / Math.Sqrt(1 - Math.Pow(Cos(x), 2));
        }
        public static double Sec(double x)
        {
            return 1 / Cos(x);
        }
        public static double Ln(double x)
        {
            if (x == 0)
            {
                return double.NegativeInfinity;
            }
            if (x < 0)
            {
                return double.NaN;
            }
            double count = 1;
            double totalValue = 0;
            double Iterations = 1000;
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
        public static double Log(double x, double y)
        {
            if((y > 0) && (y != 1) && (x > 0))
            {
                return Ln(x) / Ln(y);
            }
            if ((y < 0) && (x == 1))
            {
                return double.NaN;
            }
            if ((y == 0) && (x == 1))
            {
                return 0;
            }
            if ((y != 1) && (x == 1))
            {
                return 0;
            }
            if ((x == 0) && (y != 1) && (y > 0))
            {
                return Double.NegativeInfinity;
            }
            return double.NaN;
        }
    }
}
