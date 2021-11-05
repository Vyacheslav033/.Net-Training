using System;
using System.Collections.Generic;
using System.IO;
using TransportCompanyLibrary;
using System.Xml;

namespace TransportCompanyDocumentation
{
    /// <summary>
    /// Класс реализующий загрузку автотранспорта предприятия из XML-файл.
    /// </summary>
    public class ReadFromXmlFail : CheckXmlFail
    {
        /// <summary>
        /// Инициализатор класса ReadFromXmlFail.
        /// </summary>
        /// <param name="path"> Путь к файлу. </param>
        public ReadFromXmlFail(string path) : base(path)
        { 
            if ( !File.Exists(path) )
            {
                throw new ArgumentException("Файл с данным именем не существует.", path);
            }        
        }

        /// <summary>
        /// Загрузка автотранспорта предприятия из XML-файл.
        /// </summary>
        /// <returns></returns>
        public List<Transport> ReadTransportFromXml()
        {
            var transport = new List<Transport>();

            using (XmlReader reader = XmlReader.Create(path))
            {
                bool isEnd = false;
                string propertyName = "";

                string mark = "";
                string model = "";
                float weight = 0;
                int enginePower = 0;
                int loadCapacity = 0;
                FuelType fuelType = FuelType.Gasolin;
                float fuelConsumption = 0;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element )
                    {
                        propertyName = reader.Name;                      
                    }
 
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        switch (propertyName)
                        {
                            case "Mark": mark = reader.Value;
                                break;
                            case "Model": model = reader.Value;
                                break;
                            case "Weight": weight = Convert.ToSingle(reader.Value);
                                break;
                            case "EnginePower": enginePower = Convert.ToInt32(reader.Value);
                                break;                          
                            case "LoadCapacity": loadCapacity = Convert.ToInt32(reader.Value);
                                break;
                            case "FuelType":
                                fuelType = (FuelType) Enum.Parse(typeof(FuelType), reader.Value);
                                break;
                            case "FuelConsumption":
                                fuelConsumption = Convert.ToSingle(reader.Value);
                                isEnd = true;
                                break;
                            default:
                                break;
                        }
                    }

                    if (isEnd)
                    {
                        transport.Add(new Tractor(mark, model, weight, enginePower, loadCapacity, fuelType, fuelConsumption));

                        isEnd = false;
                    }     
                }
            }

            return transport;
        }
    }
}
