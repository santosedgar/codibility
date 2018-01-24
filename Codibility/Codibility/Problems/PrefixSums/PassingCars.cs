using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems.PrefixSums
{
    public class PassingCars
    {
        public static int solution(int[] A)
        {
            int count = 0;
            int multiply = 0;
            foreach(int car in A)
            {
                if(car == 0)
                {
                    multiply++;
                }
                if(multiply > 0)
                {
                    if(car == 1)
                    {
                        count += multiply;
                        if (count > 1000000000)
                            return -1;
                    }
                }
            }

            return count;
        }
    }
}
