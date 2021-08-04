using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Algorithm
{
    public class CheckDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> myhash1 = new HashSet<int>();
            for (int i = 0; i< nums.Length; i++)
            {
                if (myhash1.Contains(nums[i])) return true;
                myhash1.Add(nums[i]);
            }
            return false;
        }
    }
}
