using System;

namespace LunchroomLibrary
{

    /// <summary>
    /// Продукт.
    /// </summary>
    public abstract class Product
    {
        protected string name;

        protected double price;

        /// <summary>
        /// Инициализатор класса Product.
        /// </summary>
        /// <param name="name"> Наименование продукта. </param>
        /// <param name="price"> Цена продукта. </param>
        public Product(string name, double price)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название продукта не было указано.");
            }

            if (price <= 0)
            {
                throw new ArgumentException("Цена продукта указана не верно.", nameof(price));
            }

            this.name = name;
            this.price = price;
        }

        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get => name; }
  

        /// <summary>
        /// Стоимость.
        /// </summary>
        public double Price { get => price; }

        /// <summary>
        /// Сравнение продуктов на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Возвращает true в случае равенства объектов, в противном случае false. </returns>
        public override bool Equals(object obj)
        {
            if ( (obj != null) && (obj.GetType() == this.GetType()) )
            {
                Product p = (Product) obj;

                return (this.name == p.Name) && (this.price == p.Price);
            }

            return false;
        }

        /// <summary>
        /// Получить HashCode объекта Product.
        /// </summary>
        /// <returns> HashCode объекта Product. </returns>
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ price.GetHashCode();
        }

        /// <summary>
        /// Информация о продукте.
        /// </summary>
        /// <returns> Информация о продукте. </returns>
        public override string ToString()
        {
            return $"Name: {name}, " +
                   $"Price: {price}, ";
        }
    }
}

