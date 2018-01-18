using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.PrimeNumbers
{
    class CountFactors
    {
        public static int solution(int N)
        {
            int result = 0;
            // main idea:
            // check from 1 to "sqrt_of_N" 
            // then, taking its pair into consideration
            // ---> numFactor = numFactor * 2;

            int sqrtN = (int)Math.Sqrt(N);
            int numFactor = 0; // number of factors

            // check if i is a factor or not (by using N % i ==0)
            for (int i = 1; i <= sqrtN; i++)
            {
                if (N % i == 0)
                {
                    numFactor++;
                }
            }

            numFactor = numFactor * 2; // add its pair

            // be careful: check if "sqrtN * sqrtN == N"
            if (sqrtN * sqrtN == N)
            {
                numFactor = numFactor - 1; // minus one: avoid double counting
            }

            return numFactor;
        }
    }
}
