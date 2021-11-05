using System;
using System.Collections.Generic;
using System.Xml;
using TransportCompanyLibrary;

namespace TransportCompanyDocumentation
{
    /// <summary>
    /// Класс реализующий сохранение автотранспорта предприятия в XML-файл. 
    /// </summary>
    public class WriteInXmlFail : CheckXmlFail
    {

        /// <summary>
        /// Инициализатор класса WriteInXmlFail.
        /// </summary>
        /// <param name="path"> Путь к файлу. </param>
        public WriteInXmlFail(string path) : base(path) { }

        /// <summary>
        /// Сохранение автотранспорта предприятия в XML-файл
        /// </summary>
        /// <param name="transport"> Транспорт предприятия. </param>
        public void WriteTransportInXml(List<Transport> transport)
        {
            if (transport == null)
            {
                throw new ArgumentNullException("Переданный транспорт не может быть задокументирован, так как является null.");
            }

            var settings = new XmlWriterSettings()
            {
                IndentChars = "\t\t",
                Indent = true
            };

            using (XmlWriter writer = XmlWriter.Create(path, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("СompanyTransport");

                for (var i = 0; i < transport.Count; i++)
                {
                    writer.WriteStartElement("Transport");
                    writer.WriteAttributeString("id", i.ToString());

                    writer.WriteElementString("Type", transport[i].GetType().Name);
                    writer.WriteElementString("Mark", transport[i].Mark);
                    writer.WriteElementString("Model", transport[i].Model);
                    writer.WriteElementString("Weight", transport[i].Weight.ToString());
                    writer.WriteElementString("EnginePower", transport[i].EnginePower.ToString());
                    writer.WriteElementString("LoadCapacity", transport[i].LoadCapacity.ToString());
                    writer.WriteElementString("FuelType", transport[i].FuelType.ToString());
                    writer.WriteElementString("FuelConsumption", transport[i].FuelConsumption.ToString());
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
