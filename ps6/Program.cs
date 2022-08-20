using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than  {0}", age);
            Console.Read();
        }
    }
}
