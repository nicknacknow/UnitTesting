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
    }
}
