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
            Expressions exprs = new Expressions();
            double FirstExpression_MyCos(double x)
            {
                if (x >= 0)
                {
                    return exprs.CalculateExp1(AlternativeTrigonometry.Cos, AlternativeTrigonometry.Sin, AlternativeTrigonometry.Tan, x);
                    //return (((((Math.Tan(x) / Math.Tan(x)) + Math.Sin(x)) + Math.Tan(x)) * AlternativeTrigonometry.Csc(x)) * AlternativeTrigonometry.Sec(x));
                }
                return double.NaN;
            }
            double FirstExpression_CommonCos(double x)
            {
                if (x >= 0)
                {
                    return exprs.CalculateExp1(Math.Cos, Math.Sin, Math.Tan, x);
                    //return (((((Math.Tan(x) / Math.Tan(x)) + Math.Sin(x)) + Math.Tan(x)) * (1 / Math.Sin(x))) * (1 / Math.Cos(x)));
                }
                return double.NaN;
            }
            double SecondExpression_MyLn(double x)
            {
                if (x > 0)
                {
                    return exprs.CalculateExp2(AlternativeTrigonometry.Ln, x);
                    //return (((((Math.Log(x, 2) - Math.Log(x, 2)) * Math.Log10(x)) / (Math.Log(x, 3) / (Math.Log(x, 5) * Math.Log(x)))) + ((Math.Log(x) / (Math.Log10(x) / Math.Log(x, 2))) * Math.Log(x, 3))) * ((Math.Log(x, 2) * Math.Pow(Math.Log(x, 3), 3)) / ((Math.Log10(x) * Math.Log(x, 2)) * Math.Pow(Math.Log(x, 5), 2))));
                }
                return double.NaN;
            }
            double SecondExpression_CommonLn(double x)
            {
                if (x > 0)
                {
                    return exprs.CalculateExp2(Math.Log, x);
                    //return (((((Math.Log(x, 2) - Math.Log(x, 2)) * Math.Log10(x)) / (Math.Log(x, 3) / (Math.Log(x, 5) * AlternativeTrigonometry.Ln(x)))) + ((AlternativeTrigonometry.Ln(x) / (Math.Log10(x) / Math.Log(x, 2))) * Math.Log(x, 3))) * ((Math.Log(x, 2) * Math.Pow(Math.Log(x, 3), 3)) / ((Math.Log10(x) * Math.Log(x, 2)) * Math.Pow(Math.Log(x, 5), 2))));
                }
                return double.NaN;
            }
            [Test]
            public void Cos()
            {
                Assert.AreEqual(
                    Math.Round(AlternativeTrigonometry.Cos(5), 12, MidpointRounding.AwayFromZero), 
                    Math.Round(Math.Cos(5), 12, MidpointRounding.AwayFromZero)
                );
            }
            [Test]
            public void Sin()
            {
                Assert.AreEqual(
                    Math.Round(Math.Sqrt(1 - Math.Pow(AlternativeTrigonometry.Cos(5), 2)) * -1, 12, MidpointRounding.AwayFromZero), 
                    Math.Round(Math.Sin(5), 12, MidpointRounding.AwayFromZero)
                );
            }
            [Test]
            public void Tan()
            {
                Assert.AreEqual(
                    Math.Round(Math.Sqrt(1 - Math.Pow(AlternativeTrigonometry.Cos(5), 2)) * -1 / AlternativeTrigonometry.Cos(5), 12, MidpointRounding.AwayFromZero), 
                    Math.Round(Math.Tan(5), 12, MidpointRounding.AwayFromZero)
                );
            }
            [Test]
            public void ExpressionWithMyCosIsEqualToDefaul()
            {
                Assert.AreEqual(
                    Math.Round(FirstExpression_MyCos(5), 12, MidpointRounding.AwayFromZero), 
                    Math.Round(FirstExpression_CommonCos(5), 12, MidpointRounding.AwayFromZero)
                );
            }
            [Test]
            public void ExpressionWithMyLnIsEqualToDefaul()
            {
                Assert.AreEqual(
                    Math.Round(SecondExpression_MyLn(5), 12, MidpointRounding.AwayFromZero), 
                    Math.Round(SecondExpression_CommonLn(5), 12, MidpointRounding.AwayFromZero)
                );
            }
        }
    }
}
