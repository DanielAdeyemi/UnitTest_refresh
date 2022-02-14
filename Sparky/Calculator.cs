using System.Collections.Generic;
namespace Sparky
{
    public class Calculator
    {
        public List<int> NumberRange = new();
        public int AddNums(int a, int b)
        {
            return a + b;
        }
        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public bool isOddNum(int a)
        {
            return a % 2 != 0;
        }

        public List<int> GetOddRange(int min, int max)
        {
            NumberRange.Clear();
            for(int i = min; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    NumberRange.Add(i);
                }
            }
            return NumberRange;
        }
    }
}