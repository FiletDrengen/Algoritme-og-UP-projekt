using System;
using System.Collections.Generic;
using System.Text;

namespace Virksomhed_og_UP
{
    public class QuickSort
    {
        public static List<int> Quick(List<int> n)
        {
            if (n.Count <= 1)
            {
                return n;
            }

            int pivot = n[0];

            List<int> b = new List<int>();
            List<int> a = new List<int>();

            for (int i = 1; i < n.Count; i++)
            {
                if (n[i] < pivot)
                {
                    b.Add(n[i]);
                }
                else
                {
                    a.Add(n[i]);
                }
            }

            List<int> r = new List<int>();

            r.AddRange(Quick(b));
            r.Add(pivot);
            r.AddRange(Quick(a));

            return r;
        }
    }
}