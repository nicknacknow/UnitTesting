namespace ProjectEulerSolutions
{
    public class Problem1
    {
        public static int Solve(int max_limit = 1000)
        {
            Calculator calculator = new Calculator();
            int total = 0;
            for (int i = 0; i < max_limit; i++)
            {
                bool valid = calculator.CheckThisIsMultipleOfThat(i, 3) || calculator.CheckThisIsMultipleOfThat(i, 5);
                if (valid)
                    total += i;
            }
            return total;
        }
    }
}