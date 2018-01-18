using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.TimeComplexity
{
    class FromJmp
    {
        public static int solution(int X, int Y, int D)
        {
            int dif = (Y - X);
            if (dif % D == 0)
                return (Y - X) / D;
            else
                return ((Y - X) / D) + 1;
        }
    }
}

