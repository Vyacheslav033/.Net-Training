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
        protected MeasureUnit measure;

        /// <summary>
        /// Инициализатор класса Product.
        /// </summary>
        /// <param name="name"> Название товара. </param>
        /// <param name="count"> Количество. </param>
        /// <param name="measure"> Единица измерения товара. </param>
        /// <param name="weight"> Общий вес товара, кг. </param>
        public Product(string name, int count, MeasureUnit measure, float weight)
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

            this.name = name.Trim().ToLower();
            this.count = count;
            this.weight = weight;
            this.measure = measure;
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
            get { return weight; }
        }

        /// <summary>
        /// Единица измерения товара.
        /// </summary>
        public MeasureUnit Measure
        {
            get { return measure; }
        }

        /// <summary>
        /// Сравнение товара на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Возвращает true в случае равенства товара, в противном случае false. </returns>
        public override bool Equals(object obj)
        {
            if ( (obj != null) || (obj.GetType() == this.GetType()) )
            {
                Product p = (Product) obj;

                return (p.Name == this.name) && (p.Count == this.count) &&
                       (p.Weight == this.weight) && (p.Measure == this.measure);             
            }

            return false;
        }

        /// <summary>
        /// Получить HashCode объекта Product.
        /// </summary>
        /// <returns> HashCode объекта Product. </returns>
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ count.GetHashCode() ^ weight.GetHashCode() ^ measure.GetHashCode();
        }

        /// <summary>
        /// Наименование товара.
        /// </summary>
        /// <returns> Наименование товара. </returns>
        public override string ToString()
        {
            return name;
        }
    }
}
