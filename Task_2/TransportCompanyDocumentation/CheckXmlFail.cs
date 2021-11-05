using System;
using System.Xml;

namespace TransportCompanyDocumentation
{
    /// <summary>
    /// Проверка пути к xml файлу.
    /// </summary>
    public abstract class CheckXmlFail
    {
        protected XmlDocument xmlDoc;
        protected string path;

        /// <summary>
        /// Инициализатор класса CheckXmlFail.
        /// </summary>
        /// <param name="path"> Путь к файлу. </param>
        public CheckXmlFail(string path)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Путь к файлу не был передан.");
            }

            if (!path.Contains(".xml"))
            {
                throw new ArgumentException("Указанный файл не является xml файлом.", path);
            }

            this.path = path;

            xmlDoc = new XmlDocument();
        }
    }
}
