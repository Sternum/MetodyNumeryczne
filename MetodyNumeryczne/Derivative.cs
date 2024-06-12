using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyNumeryczne
{
    public class Derivative
    {
        public double derivativePatern1(FunctionDelegate fun, double x0, double h)
        {
            return (fun(x0 + h) - fun(x0)) / h;
        }

        public double derivativePatern2(FunctionDelegate fun, double x0, double h)
        {
            return (fun(x0 + h) - fun(x0 - h)) / (2*h);
        }
    }
}
