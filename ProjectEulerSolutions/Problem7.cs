using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    public class Problem7
    {
        public static int Solve(int nth = 10001)
        {
            Calculator calc = new Calculator();

            int primes_found = 0;
            int i = 2;
            while (primes_found != nth)
            {
                if (calc.IsPrime(i)) { 
                    primes_found++;
                    if (primes_found == nth) return i;
                }
                i++;
            }
            return -1;
        }
    }
}
