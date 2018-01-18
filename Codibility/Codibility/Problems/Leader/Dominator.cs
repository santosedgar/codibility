using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.Leader
{
    class Dominator
    {
        public static int solution(int[] A)
        {
            int N = A.Length;
            int size = 0;
            int value = -1;

            for(int i = 0; i < N; i++)
            {
                if(size == 0)
                {
                    size++;
                    value = A[i];
                }
                else
                {
                    if (value != A[i])
                        size--;
                    else
                        size++;
                }
            }

            int candidate = -1;
            if (size > 0)
                candidate = value;
            int count = 0;
            int indexLeader = -1;

            for (int i = 0; i < N; i++)
            {
                if (A[i] == candidate)
                {
                    indexLeader = i;
                    count++;
                }
            }

            if (count > N / 2) {
                return indexLeader;
            }

            return -1;
        }
    }
}
