using System;
using System.Collections.Generic;
using System.Linq;

namespace GherkingWithNunit
{
    public class Calculator
    {
        public List<int> nums = new List<int>();
        public int Sum;

        public void Add()
        {
            Sum = nums.Sum(num => num);
        }
    }
}
