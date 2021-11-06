using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Полуприцеп автоцистерна.
    /// </summary>
    public class TankerSemitrailer : Semitrailer
    {
        /// <summary>
        /// Инициализатор класса TankerSemitrailer.
        /// </summary>
        /// <param name="weight"> Вес. </param>
        /// <param name="loadCapacity"> Грузоподъёмность. </param>
        public TankerSemitrailer(float weight, int loadCapacity)
            : base(weight, loadCapacity)
        { }

        /// <summary>
        /// Проверка на возможность догрузги товара в полуприцеп автоцистерну.
        /// </summary>
        /// <param name="product"> Товар. </param>
        /// <returns> Возвращает true если товар можно догрузить, в противном случае false. </returns>
        public override bool CanAddProduct(Product product)
        {
            // В цистерну можно заливать только жидкость, проверка.
            if (product.Measure != MeasureUnit.Litre)
            {
                return false;
            }

            // В цистерну можно заливать только одинаковый товар, проверка.
            if (cargo.ProductCount > 0)
            {
                if ( (product.GetType() != cargo[0].GetType()) || (product.Name != cargo[0].Name) )
                {
                    return false;
                }
            }

            return true;
        }
    }
}
