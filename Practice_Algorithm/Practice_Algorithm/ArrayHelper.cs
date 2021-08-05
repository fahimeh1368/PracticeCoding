using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Algorithm
{
    public class ArrayHelper
    {
// O(n), space= O(n)

        public int[] RotateRight(int[] input, int k)
        {
            var size = input.Length;
            int[] result = new int[size];
            for(int i = 0; i<size; i++)
            {
                result[(i + k) % size] = input[i];
            }
            Array.Copy(result, input, size);
            return input;
            
        }
        public int[] RotateLeft (int[] input, int k)
        {
             var size = input.Length;
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                
                result[i] = input[(i + k) % size];
            }
            Array.Copy(result, input, size);
            return input;

        }

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> nums = new Dictionary<int,int>();

            var result = new ArrayList();
            for(int i= 0; i<nums1.Length; i++)
            {
                if (nums.ContainsKey(nums1[i]))
                {
                    nums[nums1[i]]++;
                }
                else
                    nums.Add(nums1[i], 1);
            }
            
            for (int j=0; j<nums2.Length; j++)
            {
                
                if (nums.ContainsKey(nums2[j]) && nums[nums2[j]]!=0)
                {
                    var ch = nums2[j];
                    result.Add( nums2[j]);
                    nums[nums2[j]]--;
                    
                }
            }
            int[] resultArray = result.ToArray(typeof(int)) as int[];
            return resultArray;
        }
    }
}
