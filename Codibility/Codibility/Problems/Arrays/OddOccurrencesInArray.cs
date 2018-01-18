using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.Arrays
{
    class OddOccurrencesInArray
    {
        public static int solution(int[] A)
        {
            int result = 0;

            HashSet<int> hash = new HashSet<int>();

            for(int i = 0; i < A.Length; i++)
            {
                if (hash.Contains(A[i]))
                    hash.Remove(A[i]);
                else
                    hash.Add(A[i]);
            }

            return hash.First();
        }
    }
}
