using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class CountFairPairsSolution
    {
        public long CountFairPairs(int[] nums, int lower, int upper)
        {
            int count = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum = nums[i] + nums[j];
                    if (sum >= lower && sum <= upper) count++;
                }

            }
            return count;
        }
    }
}
