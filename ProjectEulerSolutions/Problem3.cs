namespace ProjectEulerSolutions
{
    public class Problem3
    {
        // cant use polymorphism here : / ... could add double Solve in ProblemClass but no point
        public static double Solve(double number = 600851475143)
        {
            Calculator calc = new Calculator();

            List<double> primes = new List<double>();

            double n = number;
            while (n != 1)
            {
                // faster to just check 2 once then only check odds from then on.
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
