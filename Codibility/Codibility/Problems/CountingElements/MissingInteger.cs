using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.CountingElements
{
    class MissingInteger
    {
        public static int solution(int[] A)
        {
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                    hash.Add(A[i]);
            }

            if (hash.Count == 0)
                return 1;

            for (int i = 1; i < A.Length; i++)
            {
                if (!hash.Contains(i))
                    return i;
            }

            if (hash.Count == 1)
                return 1;

            return A.Length + 1;
        }
    }
}
