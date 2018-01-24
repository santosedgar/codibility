using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility.Problems
{
    public class Teste
    {
        public class Point2D
        {
            public int x;
            public int y;
        };

        public int solution(Point2D[] A)
        {
            HashSet<int> hashSet = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                hashSet.Add(A[i].y);
            }



            return A.Length;
        }

        public static int solution2(int[] A)
        {
            if (A.Length == 0)
                return 0;

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Array.Sort(A);
            int longest = int.MinValue;


            int value = A[0];
            int countQuasi = 1;

            int indexIntChange = 0;
            int valueIntChange = A[0];
            int index = 1;
            while (index < A.Length)
            {
                if (value == A[index])
                {
                    countQuasi++;
                    if (countQuasi > longest)
                        longest = countQuasi;
                }
                else
                {
                    if (valueIntChange != A[index])
                    {
                        indexIntChange = index;
                        valueIntChange = A[index];
                    }
                    if (Math.Abs(value - valueIntChange) == 1)
                    {
                        countQuasi++;
                        if (countQuasi > longest)
                            longest = countQuasi;
                    }
                    else
                    {
                        value = valueIntChange;
                        index = indexIntChange;
                        countQuasi = 1;
                    }
                }
                index++;
            }

            if (longest == int.MinValue)
                return 0;
            else
                return longest;
        }

        public static int solution3(int[] A)
        {
            if (A.Length == 0)
                return 0;

            bool isOrdered = true;
            for(int i = 1; i < A.Length; i++)
            {
                if (A[i - 1] > A[i])
                    isOrdered = false;
            }
            if (isOrdered)
                return 1;

            List<Tuple<int, int>> listTuple = new List<Tuple<int, int>>();

            int start = 0;
            int end = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if(i + 1 >= A.Length)
                {
                    listTuple.Add(new Tuple<int, int>(start, i));
                    start = i;
                }

                else if (A[i] < A[i+1])
                {
                    listTuple.Add(new Tuple<int, int>(start, i));
                    start = i;
                }
            }

            int index = 1;
            int value = A[0];

            int countGroups = 1;
            int status = 0; //0 means split /// 1 means same group

            foreach (var tuple in listTuple)
            {
                if (tuple.Item1 == tuple.Item2)
                {
                    countGroups++;
                    continue;
                }

                index = tuple.Item1;
                while (index <= tuple.Item2)
                {
                    if (value < A[index] && Math.Abs(value - A[index]) == 1)
                    {
                        status = 1;
                        countGroups++;
                    }
                    else if (value > A[index] && Math.Abs(value - A[index]) == 1)
                    {
                        status = 0;
                    }
                    else
                    {
                        status = 0;
                    }

                    value = A[index];
                    index++;
                }
            }

            return countGroups;
        }
    }
}
