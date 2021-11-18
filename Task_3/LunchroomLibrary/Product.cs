using System;

namespace LunchroomLibrary
{

    /// <summary>
    /// Продукция.
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
                throw new ArgumentNullException("Цена продукта указана не верно.", nameof(price));
            }

            this.name = name;
            this.price = price;
        }

        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Стоимость.
        /// </summary>
        public double Price
        {
            get { return price; }
        }


        public override bool Equals(object obj)
        {
            if ( (obj != null) && (obj.GetType() == this.GetType()) )
            {
                Product p = (Product) obj;

                return (this.name == p.Name) && (this.price == p.Price);
            }

            return false;
        }

    }
}

