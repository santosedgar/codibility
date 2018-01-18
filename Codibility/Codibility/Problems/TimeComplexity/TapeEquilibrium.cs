using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.TimeComplexity
{
    class TapeEquilibrium
    {
        public static int solution(int[] A)
        {
            int result = int.MaxValue;

            Dictionary<int, int> dictLeft = new Dictionary<int, int>();
            int sumLeft = 0;
            for(int i = 0; i < A.Length - 1; i++)
            {
                sumLeft += A[i];
                dictLeft.Add(i, sumLeft);
            }

            Dictionary<int, int> dictRight = new Dictionary<int, int>();
            int sumRight = 0;
            for (int i = A.Length - 1; i > 0; i--)
            {
                sumRight += A[i];
                dictRight.Add(i, sumRight);
            }
            
            for (int i = 0; i < dictRight.Count; i++)
            {
                int aux = (int)Math.Abs(dictRight.ElementAt(i).Value - dictLeft.ElementAt(A.Length - 2 - i).Value);
                if (aux < result)
                    result = aux;
            }

            return result;
        }
    }
}
