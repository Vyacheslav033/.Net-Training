using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SerializationLibrary
{
    /// <summary>
    /// Файловый сериализатор.
    /// </summary>
    public static class JsonFileSerializer
    {
        /// <summary>
        /// Сериализация объектов.
        /// </summary>
        /// <typeparam name="T"> Тип объектов. </typeparam>
        /// <param name="path"> Путь к файлу. </param>
        /// <param name="list"> Лист объектов. </param>
        public static void Serialize<T>(string path, List<T> list)
        {
            bool append = File.Exists(path) ? true : false;

            using (StreamWriter sw = new StreamWriter(path, append))
            {
                foreach (T obj in list)
                {
                    var jsonString = JsonConvert.SerializeObject(obj);
                    sw.WriteLine(jsonString);
                }
            }
        }

        /// <summary>
        /// Десериализация.
        /// </summary>
        /// <typeparam name="T"> Тип объектов. </typeparam>
        /// <param name="path"> Путь к файлу с серилизованными объектами. </param>
        /// <returns> Возвращает список объектов, хранящихся в файле. </returns>
        public static List<T> Deserialize<T>(string path)
        {
            if ( !File.Exists(path) )
            {
                throw new ArgumentException($"Файл {path} не был найден.");
            }

            var list = new List<T>();
            
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    var obj = JsonConvert.DeserializeObject<T>(line);
                    list.Add(obj);
                }
            }

            return list;
        }

    }
}
