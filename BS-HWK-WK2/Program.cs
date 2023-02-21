using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_HWK_WK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            // 非LINQ三角形
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write(n - i);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
