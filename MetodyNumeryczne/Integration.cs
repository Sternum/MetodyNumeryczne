using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyNumeryczne
{
    
    public class Integration
    {

        public double Square(FunctionDelegate fun, FunctionScope scope, int resolution)
        {
            double value = 0;
            double dx = (scope.End - scope.Start) / resolution;
            double x0 = scope.Start + dx / 2;

            if (scope.Validator != null)
            {
                if (!scope.Validator(scope.Start, scope.End))
                {
                    return value;
                }
            }

            for (int i = 0; i < resolution; i++)
            {   
                value += fun(x0 + i * dx) * dx;
            }

            return value;
        }

        public double Trapezoidal(FunctionDelegate fun, FunctionScope scope, int resolution)
        {
            double value = 0;
            double dx = (scope.End - scope.Start) / resolution;
            double x0 = scope.Start;

            if(scope.Validator != null)
            {
                if(!scope.Validator(scope.Start, scope.End))
                {
                    return value;
                }
            }

            for(int i = 0; i < resolution; i++)
            {
                value += ((fun(x0 + i * dx) + fun(x0 + (i + 1) * dx)) * dx / 2);
            }

            return value;
        }

        public double Simpson(FunctionDelegate fun, double a, double b, int n)
        {
            double sum = 0;
            double h = (b - a) / n;
            sum = fun(a) + fun(b);

            for (int i = 1; i < n; i += 2)
            {
                sum += 4 * fun(a + i * h); 
            }
            for (int i = 2; i < n - 1; i += 2)
            {
                sum += 2 * fun(a + i * h); 
            }

            return sum * (h / 3);
        }
    }
}
