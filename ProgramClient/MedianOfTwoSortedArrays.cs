using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramClient
{
    class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] num1, int[] num2)
        {

            int l1 = num1.Length;
            int l2 = num2.Length;

            int total = l1 + l2;
            Console.WriteLine(total);
            int[] array = new int[total];
            int i1 = 0;
            int i2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i1 == l1)
                {
                    array[i] = num2[i2];
                    i2++;
                    continue;
                }

                if (i2 == l2)
                {
                    array[i] = num1[i1];
                    i1++;
                    continue;
                }

                int a = num1[i1];
                int b = num2[i2];



                if (a < b)
                {
                    array[i] = a;
                    i1++;
                }

                if (a > b)
                {
                    array[i] = b;
                    i2++;
                }

                if (a == b)
                {
                    array[i] = a;
                    i++;
                    array[i] = a;
                    i1++;
                    i2++;
                }

                Console.WriteLine(array[i]);
            }

            if (total % 2 == 1)
            {
                return (double)(array[total / 2]);
            }
            else
            {
                return ((array[total / 2] + array[total / 2 - 1]) / 2.0);
            }
        }
    }
}
