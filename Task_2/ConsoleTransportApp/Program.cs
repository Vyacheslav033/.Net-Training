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
            //var tr = new Tractor("volvo", "fx200", 3000, 500, 700, 5000,FuelType.Gasolin, 30);

            //tr.Semitrailer = new TentedSemitrailer(700, 2000); ;

            //var rs = tr.GetConsumptionPerDistance(100);

            //Console.WriteLine(rs);

            try
            {
                var milk = new Milk("Молоко", 500, MeasureUnit.Litre, 2100, -10, 10);
                var milk2 = new Milk("Молоко", 300, MeasureUnit.Litre, 500, -10, 10);
                var mercury = new Mercury("Ртуть", 500, MeasureUnit.Litre, 550);
                var mercury2 = new Mercury("wew", 1000, MeasureUnit.Litre, 550);
                var fuel = new Fuel("Ртуть", 500, MeasureUnit.Litre, 550);

                var semitrailer = new RefrigeratedSemitrailer(700, 2000);


                semitrailer.Cargo.AddProduct(milk);

                semitrailer.Cargo.AddProduct(milk2);
                semitrailer.Cargo.AddProduct(mercury2);



                foreach (Product product in semitrailer.Cargo.Product)
                {
                    Console.WriteLine(product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            //Console.WriteLine(milk1);

            //var transport = new List<Transport>()
            //{
            //    new Tractor("volvo", "fx200", 3000, 500, 220, 5000, FuelType.Gasolin, 24.5f),
            //    new Tractor("Man", "i2000", 3500, 500, 450, 5000, FuelType.Gas, 55),
            //    new Tractor("Белаз", "1", 5000, 2000, 5000, 1000, FuelType.Gasolin, 300),
            //    new Tractor("DAF", "3", 4000, 2000, 5000, 900, FuelType.Diesel, 50),
            //};

            ////string path = @"D:\C#\.Net-Training\Task_2\CompanyTransport.xml";

            ////WriteInXmlFail w = new WriteInXmlFail(path);
            ////w.WriteTransportInXml(transport);

            ////ReadFromXmlFail r = new ReadFromXmlFail(path);

            ////var list = r.ReadTransportFromXml();

            //foreach (Tractor tractor in transport)
            //{
            //    //Console.WriteLine(tractor);
            //    Console.WriteLine(tractor.GetConsumptionPerDistance(90));
            //}


            Console.ReadLine();
        }
    }
}
