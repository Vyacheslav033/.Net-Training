using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Тентованный полуприцеп.
    /// </summary>
    public class TentedSemitrailer : Semitrailer
    {
        /// <summary>
        /// Инициализатор класса TentedSemitrailer.
        /// </summary>
        /// <param name="weight"> Вес. </param>
        /// <param name="loadCapacity"> Грузоподъёмность. </param>
        public TentedSemitrailer(float weight, int loadCapacity)
            : base(weight, loadCapacity)
        { }

        /// <summary>
        /// Проверка на возможность догрузги товара в тентованный полуприцеп.
        /// </summary>
        /// <param name="product"> Товар. </param>
        /// <returns> Возвращает true если товар можно догрузить, в противном случае false. </returns>
        public override bool CanAddProduct(Product product)
        {
            // В тентованный полуприцеп можно догружать товары одинакового типа, проверка.
            if (cargo.ProductCount > 0)
            {
                if (product.GetType().BaseType != cargo[0].GetType().BaseType)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
