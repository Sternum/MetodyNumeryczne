using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyNumeryczne
{
    public class ZeroPoints
    {
        public double Bisection(FunctionDelegate fun, double a, double b, int n)
        {
            double m, x0 = 0.0;

            if(fun(a) * fun(b) < 0)
            {
                
                for (int i = 0; i < n; i++)
                {
                    m = (a + b) / 2;
                    
                    if (fun(a) * fun(m) <= 0)
                    {
                        b = m;
                    } else
                    {
                        a = m;
                    }
                    x0 = m;
                }
            }
            return x0;
        }

        public double Newton(FunctionDelegate fun, FunctionDelegate funDerative, double x0, int n)
        {
            for(int i = 0; i < n; i++)
            {
               
                x0 = x0 - fun(x0) / funDerative(x0);
            }

            return x0;
        }
    } 
}
