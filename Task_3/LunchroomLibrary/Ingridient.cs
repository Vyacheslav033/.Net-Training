using System;

namespace LunchroomLibrary
{
    /// <summary>
    /// Ингридиент.
    /// </summary>
    public abstract class Ingridient : Product
    {
        private double count;

        private StorageConditions storageConditions;

        /// <summary>
        /// Инициализатор класса Ingridient.
        /// </summary>
        /// <param name="name"> Наименование ингридиента. </param>
        /// <param name="price"> Цена ингридиента. </param>
        /// <param name="count"> Количество ингридиента, гр.</param>
        public Ingridient(string name, double price, double count, StorageConditions storageConditions)
            : base(name, price)
        {
            if (count <= 0)
            {
                throw new ArgumentException("Количество ингридиента указано не верно.", nameof(count));
            }

            if (storageConditions == null)
            {
                throw new ArgumentNullException("Условия хранения ингридиента не были указаны.",
                    nameof(storageConditions));
            }

            this.count = count;
            this.storageConditions = storageConditions;
        }

        /// <summary>
        /// Количество, гр.
        /// </summary>
        public double Count { get => count; }

        /// <summary>
        /// Условия хранения.
        /// </summary>
        public StorageConditions StorageConditions { get => storageConditions; }

        /// <summary>
        /// Сравнение ингридиентов на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Возвращает true в случае равенства объектов, в противном случае false. </returns>
        public override bool Equals(object obj)
        {
            if ( base.Equals(obj) )
            {
                Ingridient ingridient = (Ingridient)obj;

                return (this.count == ingridient.Count) && (this.storageConditions.Equals(ingridient));
            }

            return false;
        }

        /// <summary>
        /// Получить HashCode объекта Ingridient.
        /// </summary>
        /// <returns> HashCode объекта Ingridient. </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ count.GetHashCode() ^ storageConditions.GetHashCode();
        }

        /// <summary>
        /// Информация об ингридиенте.
        /// </summary>
        /// <returns> Информация об ингридиенте. </returns>
        public override string ToString()
        {
            return base.ToString() +
                   $"Count: {count}, " +
                   storageConditions.ToString();
        }
    }
}
