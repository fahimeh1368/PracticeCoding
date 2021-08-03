using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Algorithm
{
    public class RemoveDuplicates
    {
        public int RemoveDuplicatesNumber(int[] nums)
        {
            if (nums.Length == 0) return 0;
           
            int i = 0;
            for (int j = 1; j< nums.Length; j++)
            {
                if(nums[i]!= nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                }
               

            }
            return i + 1;
        }
    }
}