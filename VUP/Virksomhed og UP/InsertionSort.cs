using System;
using System.Collections.Generic;
using System.Text;

namespace Virksomhed_og_UP
{
    public class InsertionSort
    {
        public static List<int> Insertionsort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        int temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}