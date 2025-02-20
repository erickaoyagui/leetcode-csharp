using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class MinimumOperationsToExceedThresholdValueIISolution
    {
        // Passes 672/676 testcases
        // Need to improve performance
        public int MinOperations(int[] nums, int k)
        {
            int counter = 0;
            List<long> numsList = nums.Select(n => (long)n).ToList();

            while (numsList.Min() < k)
            {
                long x = numsList.Min();
                numsList.Remove(x);
                long y = numsList.Min();
                numsList.Remove(y);
                numsList.Add(CalculateNumber(x, y));
                counter++;
            }

            return counter;
        }

        public long CalculateNumber(long x, long y)
        {
            return (Math.Min(x, y) * 2 + Math.Max(x, y));
        }
    }
}
