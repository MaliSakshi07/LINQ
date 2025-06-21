using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Select_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = { 10, 12, 24, 22, 34, 46, 6, 15 };

            var a = from i in age where i > 20 select i;

            foreach(int item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
