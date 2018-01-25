using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.StackQueue
{
    class Nesting
    {
        public static int solution(string S)
        {
            int result = 0;

            if (S == string.Empty)
                return 1;

            if (S[0] == ')')
                return 0;
            else
                result++;

            foreach (int i in Enumerable.Range(1, S.Length - 1))
            {
                if(result < 0)
                {
                    return 0;
                }

                if (S[i] == '(')
                    result++;
                else
                    result--;
            }

            return result == 0 ? 1 : 0;
        }
    }
}
