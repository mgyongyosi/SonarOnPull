using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarOnPull
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result:" + AddNumbers(3,4,52,3));
            Console.WriteLine("Result:" + AddAndSubstractNumbers(3, 10, 52,55));
        }

        static int AddNumbers(params int[] n)
        {
            int result = 0;
            foreach(int num in n)
            {
                result += num;
            }
            while(true) { }
            return result;
        }

        static int AddAndSubstractNumbers(params int[] nums)
        {
            int result = 0;
            foreach(int num in nums)
            {
                result += num;
            }
            foreach(int num in nums)
            {
                result -= (num - 2);
            }
            return result;
        }
    }
}
