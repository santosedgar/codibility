using Codibility.Problems;
using Codibility.Problems.BinarySearch;
using Codibility.Problems.CountingElements;
using Codibility.Problems.Leader;
using Codibility.Problems.PrefixSums;
using Codibility.Problems.PrimeNumbers;
using Codibility.Problems.StackQueue;
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

            //Debug.WriteLine(String.Join(",", MaxCounters.solution(5, new int[] { 3,4,4,6,1,4,4 })));

            //Debug.WriteLine(CountDiv.solution(10, 20, 2));

            //Debug.WriteLine(PassingCars.solution(new int[] { 1,0,1 }));
            //Debug.WriteLine(MinPerimeterRectangle.solution(30));
            Debug.WriteLine(Nesting.solution("(()(())())"));
        }
    }
}
