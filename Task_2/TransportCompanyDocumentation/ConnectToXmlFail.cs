using System;
using System.Xml;

namespace TransportCompanyDocumentation
{
    public abstract class ConnectToXmlFail
    {
        private XmlDocument xmlDoc;
        protected string path;

        public ConnectToXmlFail(string path)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Путь к файлу не был передан.");
            }

            if (!path.Contains(".xml"))
            {
                throw new ArgumentException("Указанный файл не является xml файлом.");
            }

            this.path = path;

            xmlDoc = new XmlDocument();
        }

        public void Connect()
        {
            xmlDoc.Load(path);
        }

        public void Save()
        {
            xmlDoc.Save(path);
        }
    }
}
