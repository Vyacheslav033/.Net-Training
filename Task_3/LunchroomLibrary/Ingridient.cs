using System;

namespace LunchroomLibrary
{
    /// <summary>
    /// Ингридиент.
    /// </summary>
    public abstract class Ingridient
    {
        protected string name;
        protected double cost;
        private double count;
        private StorageConditions storageConditions;

        /// <summary>
        /// Инициализатор класса Ingridient.
        /// </summary>
        /// <param name="name"> Наименование ингридиента. </param>
        /// <param name="cost"> Стоимость ингридиента. </param>
        /// <param name="count"> Количество ингридиента, гр.</param>
        public Ingridient(string name, double cost, double count, StorageConditions storageConditions)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название ингридиента не было указано.",
                    nameof(name));
            }

            if (cost <= 0)
            {
                throw new ArgumentException("Стоимость ингридиента указана не верно.",
                    nameof(cost));
            }
         
            if (count <= 0)
            {
                throw new ArgumentException("Количество ингридиента указано не верно.",
                    nameof(count));
            }

            if (storageConditions == null)
            {
                throw new ArgumentNullException("Условия хранения ингридиента не были указаны.",
                    nameof(storageConditions));
            }

            this.name = name;
            this.cost = cost;
            this.count = count;
            this.storageConditions = storageConditions;
        }

        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get => name; }

        /// <summary>
        /// Стоимость.
        /// </summary>
        public double Cost { get => cost; }

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
            if ( (obj != null) && (obj.GetType() == GetType()) )
            {
                Ingridient i = (Ingridient)obj;

                return (name == i.Name) && (cost == i.Cost) &&
                       (count == i.Count) && (storageConditions.Equals(i));
            }

            return false;
        }

        /// <summary>
        /// Получить HashCode объекта Ingridient.
        /// </summary>
        /// <returns> HashCode объекта Ingridient. </returns>
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ cost.GetHashCode() ^
                   count.GetHashCode() ^ storageConditions.GetHashCode();
        }

        /// <summary>
        /// Информация об ингридиенте.
        /// </summary>
        /// <returns> Информация об ингридиенте. </returns>
        public override string ToString()
        {
            return $"Name: {name}, " +
                   $"Cost: {cost}, " +
                   $"Count: {count}, " +
                   storageConditions.ToString();
        }
    }
}
