using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polynomial;

namespace Polynomial.Tests
{
    [TestClass]
    public class PolynomialTest
    {
        [TestMethod]
        public void PolynomOper()
        {
            double[] coef1 = new double[] { 8, 3, 5, 10, 97 };
            double[] coef2 = new double[] { 1, 4, 5, 7, 9 };
            double[] coef3 = new double[] { 1, 3, 5, 7, 9 };
            double[] coef4 = new double[] { 1, 3, 5, 7, 9 };
           

            Polynomial pol1 = new Polynomial(coef1);
            Polynomial pol2 = new Polynomial(coef2);
            Polynomial pol3 = new Polynomial(coef3);
            Polynomial pol4 = new Polynomial(coef4);
            

            Assert.AreEqual(pol1.ToString(), "F(x) = 97x^5+10x^4+5x^3+3x^2+8x^1");
            Assert.IsFalse(pol1.Equals(pol2));
            Assert.IsTrue(pol3.Equals(pol4));
            Assert.AreEqual((pol1 + pol2).ToString(), "F(x) = 106x^5+17x^4+10x^3+7x^2+9x^1");
            Assert.AreEqual((pol1 - pol2).ToString(), "F(x) = 88x^5+3x^4+0x^3+-1x^2+7x^1");
            Assert.AreEqual((pol1 * pol2).ToString(), "F(x) = 873x^5+70x^4+25x^3+12x^2+8x^1");
        }


    }
}
