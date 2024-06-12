using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyNumeryczne
{
    public class Interpolation
    {

        public double Lagrange(double[] x, double[] y, double xToEvaluate)
        {
            int n = x.Length;
            double result = 0.0;

            for (int i = 0; i < n; i++)
            {
                double term = y[i];
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        term *= (xToEvaluate - x[j]) / (x[i] - x[j]);
                    }
                }
                result += term;
            }

            return result;
        }
    }
}
