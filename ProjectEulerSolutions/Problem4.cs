namespace ProjectEulerSolutions
{
    public class Problem4
    {
        public static int Solve()
        {
            Calculator calc = new Calculator();
            List<int> myPals = new List<int>();

            for (int x = 100; x <= 999; x++)
                for (int y = 100; y <= 999; y++)
                    if (calc.IsPalindrome(x * y))
                        myPals.Add(x * y);

            return myPals.Max();
        }
    }
}
