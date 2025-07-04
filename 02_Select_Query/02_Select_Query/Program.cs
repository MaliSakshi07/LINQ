using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Select_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "sakshi", "akanksha", "sanskruti", "maya", "snehal" };
            var value = from name in names where name.StartsWith("s") select name;

            foreach(string item in value)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
