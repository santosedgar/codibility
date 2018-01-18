using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.CountingElements
{
    class PermCheck
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            HashSet<int> hash = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 1 || A[i] > A.Length)
                    return 0;
                if (hash.Contains(A[i]))
                    return 0;
                hash.Add(A[i]);
            }

            for (int i = 1; i < A.Length; i++)
            {
                if (hash.Contains(i) == false)
                    return 0;
            }

            return 1;

        }
    }
}
