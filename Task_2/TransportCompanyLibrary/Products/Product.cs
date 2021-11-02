using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Товар.
    /// </summary>
    public abstract class Product
    {
        protected string name;
        protected int count;
        protected float weight;

        /// <summary>
        /// Инициализатор класса Product.
        /// </summary>
        /// <param name="name"> Наименование товара. </param>
        /// <param name="count"> Количество. </param>
        /// <param name="weight"> Вес 1 шт. </param>
        public Product(string name, int count, float weight)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название продукта не было указано.");
            }

            if (count <= 0)
            {
                throw new ArgumentNullException("Минимальное количество товара 1 шт.", nameof(count));
            }

            if (weight <= 0)
            {
                throw new ArgumentNullException("Вес товара должен быть больше 0.", nameof(count));
            }

            this.name = name;
            this.count = count;
            this.weight = weight;
        }

        /// <summary>
        /// Наименование товара.
        /// </summary>
        public string Name 
        { 
            get { return name; }
        }

        /// <summary>
        /// Количество товара.
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Общий вес товара.
        /// </summary>
        public float Weight
        {
            get { return weight * count; }
        }
    }
}
