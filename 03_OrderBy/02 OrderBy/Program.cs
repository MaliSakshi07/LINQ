using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = { 10, 11, 22, 34, 65, 43, 6, 7, 75, 67, 45 };
            var no = from value in age where value > 18 orderby value descending select value;

            foreach (int item in no)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nThese Candidates are eligible for vote...");
            Console.ReadKey();
        }
    }
}
