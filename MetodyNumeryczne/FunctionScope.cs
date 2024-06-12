using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyNumeryczne
{
    public delegate bool Validator(double start,  double end);

    public class FunctionScope
    {
        public double Start { get; }
        public double End { get; }
        public Validator? Validator { get; }

        public FunctionScope(double start, double end, Validator validator)
        {
            Start = start;
            End = end;
            Validator = validator;
        }

        public FunctionScope(double start, double end)
        {
            Start = start;
            End = end;
        }
    }
}
