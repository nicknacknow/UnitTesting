using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    public class Problem9
    {
        public static double Solve(int max = 1000)
        {
            Calculator calc = new Calculator();

            for (double a = 1; a < max; a++)
                for (double b = 1; b < max; b++)
                    if (calc.IsSquareNumber(a * a + b * b))
                    {
                        double c = Math.Sqrt(a * a + b * b);
                        if (a + b + c == 1000) return a * b * c;
                    }

            return -1;
        }
    }
}
