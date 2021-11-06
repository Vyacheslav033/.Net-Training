using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Полуприцеп рефрижератор.
    /// </summary>
    public class RefrigeratedSemitrailer : Semitrailer
    {
        /// <summary>
        /// Инициализатор класса RefrigeratedSemitrailer.
        /// </summary>
        /// <param name="weight"> Вес. </param>
        /// <param name="loadCapacity"> Грузоподъёмность. </param>
        public RefrigeratedSemitrailer(float weight, int loadCapacity)
            : base(weight, loadCapacity)
        { }

        /// <summary>
        /// Проверка на возможность догрузги товара в полуприцеп рефрижератор.
        /// </summary>
        /// <param name="product"> Товар. </param>
        /// <returns> Возвращает true если товар можно догрузить, в противном случае false. </returns>
        public override bool CanAddProduct(Product product)
        {
            // Товары, со спец. термических условиями перевозки,
            // перевозятся в рефрижераторах, проверка.
            if (!product.GetType().IsSubclassOf(typeof(ProductWithThermalCondition)))
            {
                return false;
            }

            // Температура перевозки товаров должна быть сопоставимой, проверка.
            if (cargo.ProductCount > 0)
            {
                var prod = (ProductWithThermalCondition) cargo[0];

                if (!prod.CheckTemperatureCompatibility( (ProductWithThermalCondition) product))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
