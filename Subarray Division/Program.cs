using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subarray_Division
{
    class Program
    {
        /*
      * Complete the 'birthday' function below.
      *
      * The function is expected to return an INTEGER.
      * The function accepts following parameters:
      *  1. INTEGER_ARRAY s
      *  2. INTEGER d
      *  3. INTEGER m
      */

        public static int birthday(List<int> s, int d, int m)
        {
            int sum = 0;
            int results = 0;
            for (int i = 0; i < s.Count() - m + 1; i++)
            {
                sum = s.Skip(i).Take(m).Sum();
                if (sum == d)
                {
                    results++;
                }
            }
            return results;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = Program.birthday(s, d, m);

            Console.WriteLine(result);

        }
    }
}