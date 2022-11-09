using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    public class Problem10
    {
        public static long Solve(int max = 2_000_000)
        { // should probably start using uint but oh well
            /*Calculator calc = new Calculator();
            long ret = 2;
            int x = 0;

            for (int i = 3; i <= max; i += 2)
            {
                if (calc.IsPrime(i))
                {
                    ret += i;
                    //Console.WriteLine(i);
                    x++;
                    if (x == 10000)
                    {
                        Console.WriteLine(i);
                        x = 0;
                    }
                }
            }

            return ret;*/

            bool[] sieve = new bool[max]; // Sieve of Eratosthenes
            Array.Fill(sieve, true);

            for (int i = 2; (i * i) < max; i++)
            {
                if (sieve[i])
                    for (int j = i * i; j < max; j += i)
                        sieve[j] = false; // get all multiplies of i and set to false ---- similar to concept in Problem3
                }

            long sum = 0;
            for (int i = 2; i < max; i++)
            {
                if (sieve[i]) sum += i;
            }
            return sum;
        }
    }
}
