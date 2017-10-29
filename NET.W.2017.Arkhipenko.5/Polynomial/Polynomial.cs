using System;
using System.Security.Cryptography.X509Certificates;

namespace Polynomial
{
    public class Polynomial
    {
        private readonly Double[] coefficients;
        
        public double[] Coefficients
        {
            get { return coefficients; }
        }

       

        public Polynomial( double [] coefficients)
        {
            this.coefficients = coefficients;
        }

        public override string ToString()
        {
            string polynomialToString = "F(x) = ";
            for (int i = Coefficients.Length-1; i > 0; i--)
            {
                polynomialToString += Coefficients[i] + "x^" + (i+1) + "+";
            }

            return polynomialToString + Coefficients[0] +"x^1";
        }

        public override bool Equals(object pol)
        {
            Polynomial coef = (Polynomial)pol;
            
            if  (coef == null)
            {
                throw new ArgumentNullException();
            }

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

        public static bool operator ==(Polynomial pol1, Polynomial pol2)
        {
            
            return pol1.Equals(pol2);
        }

        public static bool operator !=(Polynomial pol1, Polynomial pol2)
        {
            if (pol1.Equals(pol2))
            {
                return false;
            }
            return true;
        }

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
    }
}
