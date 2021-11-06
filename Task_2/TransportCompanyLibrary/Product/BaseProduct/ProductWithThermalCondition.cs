using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Товары, требующие специальных термических условий перевозки.
    /// </summary>
    public abstract class ProductWithThermalCondition : Product
    {
        protected int minGradus;
        protected int maxGradus;

        /// <summary>
        /// Инициализатор класса ProductWithThermalCondition.
        /// </summary>
        /// <param name="name"> Название товара. </param>
        /// <param name="count"> Количество. </param>
        /// <param name="measure"> Единица измерения товара. </param>
        /// <param name="weight"> Общий вес товара, кг. </param>
        /// <param name="minGradus"> Минимальный градус хранения. </param>
        /// <param name="maxGradus"> Максимальный градус хранения. </param>
        public ProductWithThermalCondition(string name, int count, MeasureUnit measure, float weight, int minGradus, int maxGradus)
            : base(name, count, measure, weight)
        {
            if (minGradus > maxGradus)
            {
                throw new ArgumentException("Температура храниения продукта была указана не верно.");
            }

            this.minGradus = minGradus;
            this.maxGradus = maxGradus;
        }

        /// <summary>
        /// Минимальный градус хранения.
        /// </summary>
        public int MinGradus
        {
            get { return minGradus; }
        }

        /// <summary>
        /// Максимальный градус хранения.
        /// </summary>
        public int MaxGradus
        {
            get { return maxGradus; }
        }

        /// <summary>
        /// Проверить совместимость температуры хранения.
        /// </summary>
        /// <param name="product"> Товар для сравнения. </param>
        /// <returns> Возвращает true в случае приемлимой температуры, в противном случае false. </returns>
        public bool CheckTemperatureCompatibility(ProductWithThermalCondition product)
        {
            if (product != null)
            {
                return (product.MinGradus >= this.minGradus) && (product.MaxGradus <= this.maxGradus);
            }

            return false;
        }

        /// <summary>
        /// Сравнение товара на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Возвращает true в случае равенства товара, в противном случае false. </returns>
        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                ProductWithThermalCondition p = (ProductWithThermalCondition)obj;

                return (p.MinGradus == this.minGradus) && (p.MaxGradus == this.maxGradus);
            }

            return false;
        }

        /// <summary>
        /// Получить HashCode объекта ProductWithThermalCondition.
        /// </summary>
        /// <returns> HashCode объекта ProductWithThermalCondition. </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ minGradus.GetHashCode() ^ maxGradus.GetHashCode();
        }

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        /// <returns> Информация о товаре. </returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
