using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchroomLibrary;

namespace LunchroomConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var product1 = new Banana("Груша", 101);
            var product2 = new Banana("Яблоко", 0.9);

            Console.WriteLine(product1.Equals(product2));

            Console.ReadLine();
        }
    }
}
