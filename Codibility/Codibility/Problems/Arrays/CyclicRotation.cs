using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.Arrays
{
    class CyclicRotation
    {
        public static int[] solution(int[] A, int K)
        {
            int[] result = new int[A.Length];
            for(int i = 0; i < A.Length; i++)
            {
                result[(i + K) % A.Length] = A[i];
            }
            return result;
        }
    }
}
