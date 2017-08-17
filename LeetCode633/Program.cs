using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode633
{
    public class Solution
    {
        public bool JudgeSquareSum(int c)
          {
      

            int a = 0;
            double b = 1/2;
            c = Convert.ToInt32(Console.ReadLine());
            int a2 = 0;
            int b2 = 0;
            int b1 = 0;
            while (a < b && b % 10 != 0)
            {
                a = a + 1;
                b = Math.Sqrt (Convert.ToDouble(c - a2));
                a2 = a * a;
                b1 = Convert.ToInt32(b);
                b2 = b1 * b1;
            };
            if ((a2 + b2) == c)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            int c = Convert.ToInt32(Console.ReadLine());
            if (Solution.JudgeSquareSum(c) == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
