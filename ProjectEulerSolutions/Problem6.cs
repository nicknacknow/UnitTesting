namespace ProjectEulerSolutions
{
    public class Problem6
    {
        private static int GetSumOfSquare(int max)
        {
            int ret = 0;
            for (int i = 0; i <= max; i++)
                ret += (i * i);

            return ret;
        }
        private static int GetSquareOfSum(int max)
        {
            int ret = 0;
            for (int i = 1; i <= max; i++)
                ret += i;

            return ret * ret;
        }
        public static int Solve(int max = 100)
        {
            return GetSquareOfSum(max) - GetSumOfSquare(max);
        }
    }
}
