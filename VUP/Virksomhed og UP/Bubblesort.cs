using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Virksomhed_og_UP
{
    public class Bubblesort
    {
        public static List<int> Bubble(List<int> numbers)
        {
            int temp;

            for (int j = 0; j <= numbers.Count - 2; j++)
            {
                for (int i = 0; i <= numbers.Count - 2; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        Thread.Sleep(1000);
                    }
                }
            }

            return numbers;
        }
    }
}