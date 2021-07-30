using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Algorithm
{
    public class RotateArray
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


    }
}
