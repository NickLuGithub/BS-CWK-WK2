using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            //for (int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(n - i);
            //        //list.Add(n - i);
            //    }
            //    Console.WriteLine();
            //}

            IEnumerable<int> numberIList = Enumerable.Range(1, n).Select(x => x);
            
            foreach (int i in numberIList.OrderByDescending(x => x))
            {
                IEnumerable<int> numberJList = Enumerable.Range(1, n - i + 1).Select(x => x);
                foreach(var j in numberJList)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
