using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Virksomhed_og_UP
{
    public class InsertionSort
    {
        public static List<int> Insertion(List<int> numbers)
        {
            int index = 0;
            while (index < numbers.Count - 1)
            {
                //for (index = 0; index < numbers.Count - 1; index++)
                {
                    //if (timer > cooldownTime)
                    {
                        for (int j = index + 1; j > 0; j--)
                        {
                            if (numbers[j - 1] > numbers[j])
                            {
                                int temp = numbers[j - 1];
                                numbers[j - 1] = numbers[j];
                                numbers[j] = temp;
                                Thread.Sleep(1000);
                            }
                        }
                        index++;
                    }
                }
            }
            return numbers;
        }
    }
}