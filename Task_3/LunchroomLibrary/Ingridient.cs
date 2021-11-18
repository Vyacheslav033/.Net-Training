using System;

namespace LunchroomLibrary
{
    /// <summary>
    /// Ингридиент.
    /// </summary>
    public abstract class Ingridient
    {
        private double count;

        /// <summary>
        /// Инициализатор класса Ingridient.
        /// </summary>
        /// <param name="name"> Наименование ингридиента. </param>
        /// <param name="price"> Цена ингридиента. </param>
        /// <param name="count"> Количество ингридиента, гр.</param>
        public Ingridient(string name, double price, double count)
            : base(name, price)
        {
            if (count <= 0)
            {
                throw new ArgumentNullException("Количество ингридиента указано не верно.", nameof(count));
            }

            this.count = count;

        }

        /// <summary>
        /// Количество, гр.
        /// </summary>
        public double Count
        {
            get { return count; }
        }
    }
}
