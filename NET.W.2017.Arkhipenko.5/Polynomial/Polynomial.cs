﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Polynomial
{
    /// <summary>
    /// class Polynomial for working with polynomials of degree n from one variable of double type.
    /// </summary>
    public class Polynomial
    {
        #region private fields
        private readonly Double[] coefficients;
        #endregion

        #region propreties
        public double[] Coefficients
        {
            get { return coefficients; }
        }
        #endregion

        #region  public
        
        public Polynomial( double [] coefficients)
        {
            this.coefficients = coefficients;
        }

        #region override 
        /// <summary>
        /// Override method ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string polynomialToString = "F(x) = ";
            for (int i = Coefficients.Length-1; i > 0; i--)
            {
                polynomialToString += Coefficients[i] + "x^" + (i+1) + "+";
            }

            return polynomialToString + Coefficients[0] +"x^1";
        }

        /// <summary>
        /// Override method Equals compares 2 polynomials
        /// </summary>
        /// <param name="pol"></param>
        /// <returns></returns>
        public override bool Equals(object pol)
        {
            Polynomial coef = (Polynomial)pol;

            if (ReferenceEquals(coef, null)) return false;
            if (ReferenceEquals(this, coef)) return true;

            if (Coefficients.Length != coef.Coefficients.Length)
            {
                return false;
            }

            int k = 0;
            for (int i = 0; i < coef.Coefficients.Length; i++)
            {
                if (Coefficients[i] == coef.Coefficients[i])
                {
                    k++;
                }
            }

            if (k == coef.Coefficients.Length)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Coefficients.Length;
        }
        #endregion

        #region == and !=
        public static bool operator ==(Polynomial pol1, Polynomial pol2)
        {
            if (ReferenceEquals(pol1, null)) return false;
            if (ReferenceEquals(pol1, pol2)) return true;

           return pol1.Equals(pol2);
        }

        public static bool operator !=(Polynomial pol1, Polynomial pol2)
        {
            if (ReferenceEquals(pol1, null)) return false;
            if (ReferenceEquals(pol1, pol2)) return true;

            return !(pol1 == pol2);
        }
        #endregion

        #region +, -, *
        /// <summary>
        /// Overloaded method +
        /// </summary>
        /// <param name="pol1"></param>
        /// <param name="pol2"></param>
        /// <returns></returns>
        public static Polynomial operator +(Polynomial pol1, Polynomial pol2)
        {
            double[] sumCoef = new double[Math.Max(pol1.Coefficients.Length, pol2.Coefficients.Length)];

            if (pol1.Coefficients.Length == pol2.Coefficients.Length)
            {
                for (int i = 0; i < pol1.Coefficients.Length; i++)
                {
                    sumCoef[i] = pol1.Coefficients[i] + pol2.Coefficients[i];
                }
            }


            if (pol1.Coefficients.Length < pol2.Coefficients.Length)
            {
                for (int i = 0; i < pol1.Coefficients.Length; i++)
                {
                    sumCoef[i] = pol1.Coefficients[i] + pol2.Coefficients[i];
                }
                for (int i = pol1.Coefficients.Length; i < pol2.Coefficients.Length; i++)
                {
                    sumCoef[i] = pol2.Coefficients[i];
                }
            }

            if (pol1.Coefficients.Length > pol2.Coefficients.Length)
            {
                for (int i = 0; i < pol2.Coefficients.Length; i++)
                {
                    sumCoef[i] = pol1.Coefficients[i] + pol2.Coefficients[i];
                }
                for (int i = pol2.Coefficients.Length; i < pol1.Coefficients.Length; i++)
                {
                    sumCoef[i] = pol1.Coefficients[i];
                }
            }

            Polynomial polSum = new Polynomial(sumCoef);
            return polSum;
        }

        /// <summary>
        /// Overloaded method -
        /// </summary>
        /// <param name="pol1"></param>
        /// <param name="pol2"></param>
        /// <returns></returns>
        public static Polynomial operator -(Polynomial pol1, Polynomial pol2)
        {
            double[] subCoef = new double[Math.Max(pol1.Coefficients.Length, pol2.Coefficients.Length)];

            if (pol1.Coefficients.Length == pol2.Coefficients.Length)
            {
                for (int i = 0; i < pol1.Coefficients.Length; i++)
                {
                    subCoef[i] = pol1.Coefficients[i] - pol2.Coefficients[i];
                }
            }


            if (pol1.Coefficients.Length < pol2.Coefficients.Length)
            {
                for (int i = 0; i < pol1.Coefficients.Length; i++)
                {
                    subCoef[i] = pol1.Coefficients[i] - pol2.Coefficients[i];
                }
                for (int i = pol1.Coefficients.Length; i < pol2.Coefficients.Length; i++)
                {
                    subCoef[i] = pol2.Coefficients[i];
                }
            }

            if (pol1.Coefficients.Length > pol2.Coefficients.Length)
            {
                for (int i = 0; i < pol2.Coefficients.Length; i++)
                {
                    subCoef[i] = pol1.Coefficients[i] - pol2.Coefficients[i];
                }
                for (int i = pol2.Coefficients.Length; i < pol1.Coefficients.Length; i++)
                {
                    subCoef[i] = pol1.Coefficients[i];
                }
            }

            Polynomial polSum = new Polynomial(subCoef);
            return polSum;
        }

        /// <summary>
        /// Overloaded method *
        /// </summary>
        /// <param name="pol1"></param>
        /// <param name="pol2"></param>
        /// <returns></returns>
        public static Polynomial operator *(Polynomial pol1, Polynomial pol2)
        {
            double[] mulCoef = new double[Math.Max(pol1.Coefficients.Length, pol2.Coefficients.Length)];

            if (pol1.Coefficients.Length == pol2.Coefficients.Length)
            {
                for (int i = 0; i < pol1.Coefficients.Length; i++)
                {
                    mulCoef[i] = pol1.Coefficients[i] * pol2.Coefficients[i];
                }
            }


            if (pol1.Coefficients.Length < pol2.Coefficients.Length)
            {
                for (int i = 0; i < pol1.Coefficients.Length; i++)
                {
                    mulCoef[i] = pol1.Coefficients[i] * pol2.Coefficients[i];
                }
                for (int i = pol1.Coefficients.Length; i < pol2.Coefficients.Length; i++)
                {
                    mulCoef[i] = pol2.Coefficients[i];
                }
            }

            if (pol1.Coefficients.Length > pol2.Coefficients.Length)
            {
                for (int i = 0; i < pol2.Coefficients.Length; i++)
                {
                    mulCoef[i] = pol1.Coefficients[i] * pol2.Coefficients[i];
                }
                for (int i = pol2.Coefficients.Length; i < pol1.Coefficients.Length; i++)
                {
                    mulCoef[i] = pol1.Coefficients[i];
                }
            }

            Polynomial polSum = new Polynomial(mulCoef);
            return polSum;
        }

        #endregion

        #endregion

    }
}
