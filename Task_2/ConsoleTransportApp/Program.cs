using System;
using TransportCompanyLibrary;

namespace ConsoleTransportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tr = new Tractor("volvo", "fx200", 3000, 500, 5000,Fuel.Gasolin, 30);

            //tr.Semitrailer = new TentedSemitrailer(700, 2000); ;

            //var rs = tr.GetConsumptionPerDistance(100);

            //Console.WriteLine(rs);

            var milk1 = new Milk("Молоко", 500, MeasureUnit.Litre, 550, -20, 10);

            Console.WriteLine(milk1);

            Console.ReadLine();
        }
    }
}
