using System;

namespace LunchroomLibrary
{
    /// <summary>
    /// Условия хранения.
    /// </summary>
    public class StorageConditions
    {
        protected int minGradus;
        protected int maxGradus;

        /// <summary>
        /// Инициализатор класса StorageConditions.
        /// </summary>
        /// <param name="minGradus"> Минимальный градус хранения. </param>
        /// <param name="maxGradus"> Максимальный градус хранения. </param>
        public StorageConditions(int minGradus, int maxGradus)
        {
            if (minGradus > maxGradus)
            {
                throw new ArgumentException("Температура храниения была указана не верно.");
            }

            this.minGradus = minGradus;
            this.maxGradus = maxGradus;
        }

        /// <summary>
        /// Минимальный градус хранения.
        /// </summary>
        public int MinGradus { get => minGradus; }

        /// <summary>
        /// Максимальный градус хранения.
        /// </summary>
        public int MaxGradus { get => maxGradus; }

        /// <summary>
        /// Узнать возможность хранения.
        /// </summary>
        /// <param name="conditions"> Условия хранения. </param>
        /// <returns> Возвращает true если условия хранения соблюдаются, в противном случае false. </returns>
        public bool IsStoragePossible(StorageConditions conditions)
        {
            if (conditions != null)
            {
                return (conditions.MinGradus >= this.minGradus) && (conditions.MaxGradus <= this.maxGradus);
            }

            return false;
        }

        /// <summary>
        /// Сравнение условий хранения на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Возвращает true в случае равенства объектов, в противном случае false. </returns>
        public override bool Equals(object obj)
        {
            if ((obj != null) && (obj.GetType() == this.GetType()))
            {
                StorageConditions sc = (StorageConditions)obj;

                return (this.minGradus == sc.MinGradus) && (this.maxGradus == sc.MaxGradus);
            }

            return false;
        }

        /// <summary>
        /// Получить HashCode объекта StorageConditions.
        /// </summary>
        /// <returns> HashCode объекта StorageConditions. </returns>
        public override int GetHashCode()
        {
            return minGradus ^ maxGradus;
        }

        /// <summary>
        /// Условия хранения.
        /// </summary>
        /// <returns> Условия хранения. </returns>
        public override string ToString()
        {
            return $"MinGradus: {minGradus}, " +
                   $"MaxGradus: {maxGradus}";
        }
    }
}
