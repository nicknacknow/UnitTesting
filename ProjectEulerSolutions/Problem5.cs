namespace ProjectEulerSolutions
{
    public class Problem5
    {
        public static int Solve()
        {
            Calculator calc = new Calculator();

            int i = 1;
            while (true)
            {
                if (calc.IsDivisibleByRange(i, 1, 20)) break;
                i++;
            }
            return i;
        }
    }
}
