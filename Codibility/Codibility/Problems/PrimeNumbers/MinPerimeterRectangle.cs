using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.PrimeNumbers
{
    class MinPerimeterRectangle
    {
        public static int solution(int N)
        {
            int x = (int)Math.Sqrt(N);
            int y = 0;

            for(int i = x; x > 0; x--)
            {
                if(N % x == 0)
                {
                    y = N / x;
                    break;
                }
            }

            return 2 * (x + y);
        }
    }
}
