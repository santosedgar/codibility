using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.TimeComplexity
{
    class PermMissingElem
    {
        public static int solution(int[] A)
        {
            HashSet<int> hash = new HashSet<int>();

            for(int i = 0; i< A.Length; i++)
            {
                hash.Add(A[i]);
            }

            for (int i = 1; i < A.Length + 1; i++)
            {
                if (!hash.Contains(i))
                    return i;
            }

            return A.Length + 1;
        }
    }
}
