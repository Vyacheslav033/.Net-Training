using System;
using System.Collections.Generic;
using TransportCompanyLibrary;
using TransportCompanyDocumentation;

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

            //var milk1 = new Milk("Молоко", 500, MeasureUnit.Litre, 550, -20, 10);

            //Console.WriteLine(milk1);

            var transport = new List<Transport>()
            {
                new Tractor("volvo", "fx200", 3000, 500, 5000, FuelType.Gasolin, 50),
                new Tractor("Man", "i2000", 3500, 500, 5000, FuelType.Gas, 55),
                new Tractor("Белаз", "1", 5000, 2000, 5000, FuelType.Gasolin, 300),
            };

            string path = @"D:\C#\.Net-Training\Task_2\CompanyTransport1.xml";

            WriteInXmlFail w = new WriteInXmlFail(path);
            w.WriteTransportInXml(transport);

            //ReadFromXmlFail r = new ReadFromXmlFail(path);

            //var list = r.ReadTransportFromXml();

            //foreach (Tractor tractor in list)
            //{
            //    Console.WriteLine(tractor);
            //}


            Console.ReadLine();
        }
    }
}
