using System;
using TransportCompanyLibrary;

namespace ConsoleTransportApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            var tr = new Tractor("volvo", "fx200", 3000, 500, 5000,Fuel.Gasolin, 30);

            tr.Semitrailer = new TentedSemitrailer(700, 2000); ;
              
            var rs = tr.GetConsumptionPerDistance(100);

            Console.WriteLine(rs);

            Console.ReadLine();
        }
    }
}
