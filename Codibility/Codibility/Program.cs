using Codibility.Problems.CountingElements;
using Codibility.Problems.Leader;
using Codibility.Problems.PrimeNumbers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Debug.WriteLine(PermCheck.solution(new int[] { 4, 1, 3, 2 }));
            //Debug.WriteLine(MissingInteger.solution(new int[] { 1, 3, 6, 4, 1, 2 }));
            //Debug.WriteLine(CountFactors.solution(24));

            Debug.WriteLine(Dominator.solution(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }));
        }
    }
}
