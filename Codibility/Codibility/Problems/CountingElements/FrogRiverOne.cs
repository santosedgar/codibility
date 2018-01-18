using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.CountingElements
{
    class FrogRiverOne
    {
        public static int solution(int X, int[] A)
        {
            int steps = X;
            bool[] bitmap = new bool[steps + 1];
            for (int i = 0; i < A.Length; i++)
            {
                if (!bitmap[A[i]])
                {
                    bitmap[A[i]] = true;
                    steps--;
                }
                if (steps == 0) return i;
            }
            return -1;
        }
    }
}
