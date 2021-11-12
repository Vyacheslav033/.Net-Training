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
            var transport = new List<Transport>()
            {
                new Tractor("volvo", "fx200", 3000, 500, 220, 5000, FuelType.Gasolin, 24.5f),
                new Tractor("Man", "i2000", 3500, 500, 450, 5000, FuelType.Gas, 55),
                new Tractor("Белаз", "1", 5000, 2000, 5000, 1000, FuelType.Gasolin, 300),
                new Tractor("DAF", "3", 4000, 2000, 5000, 900, FuelType.Diesel, 50)
            };

            var semitreilers = new List<Semitrailer>()
            {
                new RefrigeratedSemitrailer(700, 2000),
                new TentedSemitrailer(900, 2300),
                new TentedSemitrailer(1500, 3500),
                new TankerSemitrailer(1000, 3000),             
                new TankerSemitrailer(1200, 2700)               
            };

            var products = new List<Product>()
            {
                new Milk("Молоко", 60, MeasureUnit.Litre, 50, -3, 3),
                new Fuel("Бензин", 50, MeasureUnit.Litre, 45),
                new Mercury("Ртуть", 100, MeasureUnit.Litre, 110),

            };

            Console.ReadLine();
        }

        /// <summary>
        /// Просмотр автопарка предприятия.
        /// </summary>
        /// <param name="transport"> Транспорт предприятия. </param>
        private static void OutputCompanyTransport(List<Transport> transport)
        {
            foreach (Transport tr in transport)
            {
                Console.WriteLine(tr);

                if (tr is Tractor)
                {
                    Tractor tractor = (Tractor) tr;

                    if (tractor.Semitrailer != null)
                    {
                        Console.WriteLine(tractor.Semitrailer);
                    }
                }
            }
        }

        /// <summary>
        /// Нахождение полуприцепов по типу.
        /// </summary>
        /// <param name="semitrailers"> Полуприцепы компании. </param>
        /// <param name="type"> Тип полуприцепов. </param>
        /// <returns> Полуприцепы удволетворяющие поиску. </returns>
        private static List<Semitrailer> SearchSemitreilersByType(List<Semitrailer> semitrailers, Type type)
        {
            var searchSemitrailer = new List<Semitrailer>();

            foreach (Semitrailer sem in semitrailers)
            {
                if (sem.GetType() == type)
                {
                    searchSemitrailer.Add(sem);
                }
            }

            return searchSemitrailer;
        }

        /// <summary>
        /// Нахождение полуприцепов по образцу.
        /// </summary>
        /// <param name="semitrailers"> Полуприцепы компании. </param>
        /// <param name="semitrailer"> Тип полуприцепов. </param>
        /// <returns> Полуприцепы удволетворяющие поиску. </returns>
        private static List<Semitrailer> SearchSemitreilersByExample(List<Semitrailer> semitrailers, Semitrailer semitrailer)
        {
            var searchSemitrailer = new List<Semitrailer>();

            foreach (Semitrailer sem in semitrailers)
            {
                if ( sem.Equals(semitrailer) )
                {
                    searchSemitrailer.Add(sem);
                }
            }

            return searchSemitrailer;
        }

        /// <summary>
        /// Нахождение всех сцепок (полуприцеп + тягач), перевозящих заданную категорию товара.
        /// </summary>
        /// <param name="transport"> Транспорт предприятия. </param>
        /// <param name="productCategory"> Категория продукта. </param>
        /// <returns> Транспорт удволетворяющий поиску. </returns>
        private static List<Transport> SearchTractorsWithConcreteProduct(List<Transport> transport, Type productCategory)
        {
            var searchTransport = new List<Transport>();

            foreach (Transport tr in transport)
            {
                if (tr is Tractor)
                {
                    Tractor tractor = (Tractor) tr;

                    if ( (tractor.Semitrailer != null) &&
                         (tractor.Semitrailer.Cargo.IsThereProductCategory(productCategory)) )
                    {
                        searchTransport.Add(tr);
                    }
                }
            }

            return searchTransport;
        }

        /// <summary>
        /// Cохранить текущее состояние автотранспорта предприятия в XML-файл, используя XmlWriter.
        /// </summary>
        /// <param name="transport"> Транспорт предприятия. </param>
        /// <param name="path"> Путь к файлу. </param>
        private static void SaveTransportInXmlFail(List<Transport> transport, string path)
        {
            var writer = new WriteInXmlFail(path);

            writer.WriteTransportInXml(transport);
        }

        /// <summary>
        /// Загрузить состояние автотранспорта предприятия из XML-файла, используя XmlReader.
        /// </summary>
        /// <param name="path"> Путь к файлу. </param>
        /// <returns> Возвращает список автотранспорта компании. </returns>
        private static List<Transport> DownloadTransportFromXmlFail(string path)
        {
            var reader = new ReadFromXmlFail(path);

            return reader.ReadTransportFromXml();
        }
    }
}
