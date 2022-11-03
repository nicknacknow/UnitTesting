namespace ProjectEulerSolutions
{
    public class Problem2
    {
        public static int Solve(int max_value = 4000000)
        {
            List<int> seq = new List<int>{ 1, 2 };
            Calculator calc = new Calculator();

            int result = 2;
            while (true)
            {
                int val = seq.Last() + seq[seq.Count - 2];
                if (val > max_value) break;

                seq.Add(val);

                if (calc.CheckThisIsMultipleOfThat(val, 2))
                    result += val;
            }
            return result;
        }
    }
}
