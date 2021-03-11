using System;
using System.Collections.Generic;
using System.Text;

namespace Virksomhed_og_UP
{
    class Insertionsort
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 9, 3, 2, 6, 1, 4, 8, 5, 7 };

            InsertionSort(numbers);
        }

        private static void InsertionSort(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int val = numbers[i];
                int pointer = i;

                while (pointer > 0 && val < numbers[pointer - 1])
                {
                    numbers[pointer] = numbers[pointer - 1];
                    pointer = pointer - 1;
                }

                numbers[pointer] = val;
            }
        }
    }
}
