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

            double CommonExpression_MyTrigonometry(double x)
            {
                return exprs.CalculateCommonExp(AlternativeTrigonometry.Cos, AlternativeTrigonometry.Sin, AlternativeTrigonometry.Tan, AlternativeTrigonometry.Ln, AlternativeTrigonometry.Log, x);
            }
            double CommonExpression_CommonTrigonometry(double x)
            {
                return exprs.CalculateCommonExp(Math.Cos, Math.Sin, Math.Tan, Math.Log, Math.Log, x);
            }
            [Test]
            public void Cos()
            {
                for (double x = -10; x <= 10; x += 0.01)
                {
                    Assert.AreEqual
                    (
                        Math.Round(AlternativeTrigonometry.Cos(x), 10, MidpointRounding.AwayFromZero), 
                        Math.Round(Math.Cos(x), 10, MidpointRounding.AwayFromZero)
                    );
                }
            }
            [Test]
            public void Sin()
            {
                for (double x = -10; x <= 0; x += 0.01)
                {
                    Assert.AreEqual
                    (
                        Math.Round(AlternativeTrigonometry.Sin(x), 9, MidpointRounding.AwayFromZero), 
                        Math.Round(Math.Sin(x), 9, MidpointRounding.AwayFromZero)
                    );
                }
            }
            [Test]
            public void Tan()
            {
                for (double x = -10; x <= 10; x += 0.01)
                {
                    Assert.AreEqual
                    (
                        Math.Round(AlternativeTrigonometry.Tan(x), 8, MidpointRounding.AwayFromZero),
                        Math.Round(Math.Tan(x), 8, MidpointRounding.AwayFromZero)
                    );
                }
            }
            [Test]
            public void Ln()
            {
                for (double x = -10; x <= 10; x += 0.1)
                {
                        Assert.AreEqual
                    (
                        Math.Round(AlternativeTrigonometry.Ln(x), 3, MidpointRounding.AwayFromZero),
                        Math.Round(Math.Log(x), 3, MidpointRounding.AwayFromZero)
                    );
                }
            }
            [Test]
            public void Log()
            {
                for (int y = -10; y <= 10; y += 1)
                {
                    for (int x = -10; x <= 10; x += 1)
                    {
                            Assert.AreEqual
                        (
                            Math.Round(AlternativeTrigonometry.Log(x, y), 3, MidpointRounding.AwayFromZero),
                            Math.Round(Math.Log(x, y), 3, MidpointRounding.AwayFromZero)
                        );
                    }
                }
            }
            [Test]
            public void CommonExpressionWithMyTrigonometryWhere_X_IsLessOrEqualZero()
            {
                for (double x = -10; x < -0.01; x += 0.01)
                {
                    if (x == 0)
                    {
                        x += 0.1;
                    }
                    Assert.AreEqual
                    (
                        Math.Round(CommonExpression_MyTrigonometry(x), 4, MidpointRounding.AwayFromZero),
                        Math.Round(CommonExpression_CommonTrigonometry(x), 4, MidpointRounding.AwayFromZero)
                    );
                }
            }
            [Test]
            public void CommonExpressionWithMyTrigonometryWhere_X_IsMoreThanZero()
            {
                for (double x = 0.01; x <= 10; x += 0.01)
                {
                    if (x == 0)
                    {
                        x += 0.1;
                    }
                    Assert.AreEqual
                    (
                        Math.Round(CommonExpression_MyTrigonometry(x), 4, MidpointRounding.AwayFromZero),
                        Math.Round(CommonExpression_CommonTrigonometry(x), 4, MidpointRounding.AwayFromZero)
                    );
                }
            }
        }
    }
}
