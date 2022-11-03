namespace ProjectEulerSolutions
{
    public class Problem3
    {
        public static double Solve(double number = 600851475143)
        {
            Calculator calc = new Calculator();

            List<double> primes = new List<double>();

            double n = number;
            while (n != 1)
            {
                for (double i = 2; i <= n; i++)
                {
                    if (calc.CheckThisIsMultipleOfThat(n, i))
                    {
                        primes.Add(i);
                        n /= i;
                        break;
                    }
                }
            }
            return primes.Max();
        }
    }
}
