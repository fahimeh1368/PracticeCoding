﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice_Algorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            
            var rotate = new RotateArray();
            var right = rotate.RotateRight(array, 3);
            Console.WriteLine("Right rotaton is: ");
            for (int i = 0; i < right.Length; i++)
            {
                Console.Write(right[i] + " ");
            }
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var left = rotate.RotateLeft(array2, 3);
            Console.WriteLine("\n Left rotaton is: ");
            for (int i=0; i < left.Length; i++)
            {
                Console.Write(left[i]+" ");
            }
            var y = 0;
        }

    }
}