using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLab2Framework
{
    class Tests
    {
        [TestFixture]
        class ExpressionsTests
        {
            double FirstExpression_MyCos(double x)
            {
                if (x >= 0)
                {
                    return (((((Math.Tan(x) / Math.Tan(x)) + Math.Sin(x)) + Math.Tan(x)) * AlternativeTrigonometry.Csc(x)) * AlternativeTrigonometry.Sec(x));
                }
                return double.NaN;
            }
            double FirstExpression_CommonCos(double x)
            {
                if (x >= 0)
                {
                    return (((((Math.Tan(x) / Math.Tan(x)) + Math.Sin(x)) + Math.Tan(x)) * AlternativeTrigonometry.Csc(x)) * (1 / Math.Cos(x)));
                }
                return double.NaN;
            }
            double SecondExpression_MyLn(double x)
            {
                if (x > 0)
                {
                    return (((((Math.Log(x, 2) - Math.Log(x, 2)) * Math.Log10(x)) / (Math.Log(x, 3) / (Math.Log(x, 5) * Math.Log(x)))) + ((Math.Log(x) / (Math.Log10(x) / Math.Log(x, 2))) * Math.Log(x, 3))) * ((Math.Log(x, 2) * Math.Pow(Math.Log(x, 3), 3)) / ((Math.Log10(x) * Math.Log(x, 2)) * Math.Pow(Math.Log(x, 5), 2))));
                }
                return double.NaN;
            }
            double SecondExpression_CommonLn(double x)
            {
                if (x > 0)
                {
                    return (((((Math.Log(x, 2) - Math.Log(x, 2)) * Math.Log10(x)) / (Math.Log(x, 3) / (Math.Log(x, 5) * AlternativeTrigonometry.Ln(x)))) + ((AlternativeTrigonometry.Ln(x) / (Math.Log10(x) / Math.Log(x, 2))) * Math.Log(x, 3))) * ((Math.Log(x, 2) * Math.Pow(Math.Log(x, 3), 3)) / ((Math.Log10(x) * Math.Log(x, 2)) * Math.Pow(Math.Log(x, 5), 2))));
                }
                return double.NaN;
            }

            [Test]
            public void ExpressionWithMyCosIsEqualToDefaul()
            {
                Assert.AreEqual(Math.Round(FirstExpression_MyCos(5), 12, MidpointRounding.AwayFromZero), Math.Round(FirstExpression_CommonCos(5), 12, MidpointRounding.AwayFromZero));
            }
            [Test]
            public void ExpressionWithMyLnIsEqualToDefaul()
            {
                Assert.AreEqual(Math.Round(SecondExpression_MyLn(5), 12, MidpointRounding.AwayFromZero), Math.Round(SecondExpression_CommonLn(5), 12, MidpointRounding.AwayFromZero));
            }
        }
    }
}
