using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.BinarySearch
{
    class MinMaxDivision
    {
        public static int solution(int K, int M, int[] A)
        {
            //Array.Sort(A.ToArray());

            int lower = Max(A);
            int upper = Sum(A);
            while (true)
            {
                int mid = (lower + upper) / 2;
                int blocks = calculateBlockCount(A, mid);
                if (blocks < K)
                {
                    upper = mid - 1;
                }
                else if (blocks > K)
                {
                    lower = mid + 1;
                }
                else
                {
                    return upper;
                }
            }
        }

        private static int calculateBlockCount(int[] a, int maxSum)
        {
            int count = 0;
            int sum = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (sum + a[i] > maxSum)
                {
                    count++;
                    sum = a[i];
                }
                else
                {
                    sum += a[i];
                }
            }
            return count;
        }

        private static int Sum(int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            { sum += i;
            }
            return sum;
        }

        private static int Max(int[] a)
        {
            int max = -1;
            foreach (int i in a)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
    }
}

