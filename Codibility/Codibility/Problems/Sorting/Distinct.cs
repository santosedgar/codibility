using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.Sorting
{
    class Distinct
    {
        public static int solution(int[] A)
        {
            HashSet<int> hashSet = new HashSet<int>();

            for(int i =0; i< A.Length; i++)
            {
                if (!hashSet.Contains(A[i]))
                    hashSet.Add(A[i]);
            }

            return hashSet.Count;
        }
    }
}
