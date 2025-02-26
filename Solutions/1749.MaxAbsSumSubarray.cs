using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class MaxAbsSumSubarraySolution
    {
        public int MaxAbsoluteSum(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int highest = 0;
            int highestPositive = 0;
            int highestNegative = 0;

            foreach (int num in nums) { 
                highestPositive = Math.Max(0, num + highestPositive);
                highestNegative = Math.Min(0, num + highestNegative);
                highest = Math.Max(highest, Math.Max(highestPositive, -highestNegative));
            }

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    newHighest = 0;
            //    sum = 0;
            //    for (int j = i; j < nums.Length; j++)
            //    {
            //        sum += nums[j];
            //        newHighest = Math.Abs(sum);
            //        highest = (newHighest > highest) ? newHighest : highest;
            //    }
            //}

            return highest;
        }
    }
}
