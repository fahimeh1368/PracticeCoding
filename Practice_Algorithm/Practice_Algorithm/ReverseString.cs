using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Algorithm
{
    public class ReverseString
    {
        public void Reverse(char[] input)
        {
            int left = 0;
            int right = input.Length-1;
            while(left < right)
            {
                var temp = input[left];
                input[left] = input[right];
                input[right] = temp;
                left++;
                right--;
            }
        }
    }
}
