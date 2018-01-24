using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.CountingElements
{
    public class MaxCounters
    {
        public static int[] solution(int N, int[] A)
        {
            int []counters = new int[N];
            int max = 0;
            int maxInner = 0;
            int current = 0;
            for(int i = 0; i < A.Length; i++)
            {
                current = A[i];
                if (current >= 1 && current <= N)
                {
                    if (max > counters[current - 1])
                        counters[current - 1] = max;

                    counters[current - 1] = counters[current - 1] + 1;

                    if (maxInner < counters[current - 1])
                        maxInner = counters[current - 1];
                }
                else if(current == N + 1)
                {
                    max = maxInner;
                    //setMaxCounters(max, ref counters);
                }
            }
            setMaxCounters(max, ref counters);

            return counters;
        }

        public static void setMaxCounters(int max, ref int[] A)
        {
            for(int i = 0; i< A.Length; i++)
            {
                if (A[i] < max)
                    A[i] = max;
            }
        }
    }
}
