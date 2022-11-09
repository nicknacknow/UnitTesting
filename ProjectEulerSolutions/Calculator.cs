using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    public class Calculator
    {
        public Calculator() { }

        public bool CheckThisIsMultipleOfThat(int _this, int _that)
        {
            return _this % _that == 0;
        }

        public bool CheckThisIsMultipleOfThat(double _this, double _that)
        {
            return _this % _that == 0;
        }

        public bool IsPalindrome(int num)
        { // 100 % my own code not copy pasted from stackoverflow
            IEnumerable<char> forwards = num.ToString().ToCharArray();
            return forwards.SequenceEqual(forwards.Reverse());
        }

        public bool IsDivisibleByRange(int num, int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                if (!this.CheckThisIsMultipleOfThat(num, i))
                    return false;
            }
            return true;
        }

        public bool IsPrime(int num)
        {
            // A prime number is a number that does not have any factors.
            if (num == 2) return true;
            if (this.CheckThisIsMultipleOfThat(num, 2)) return false; // only even prime is 2, which we just checked for above

            for (int i = 3; i < num; i += 2) // go through every odd number (besides 1) up to num
                if (this.CheckThisIsMultipleOfThat(num, i)) return false; // if divisible, then this is a factor, therefore contradicting our first statement.

            return true; // once every number up to num has been checked must be true
        }

        public bool IsSquareNumber(double num)
        {
            return Math.Sqrt(num) % 1 == 0;
        }
    }
}
