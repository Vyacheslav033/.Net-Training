using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class Order
    {
        private int customerNumber;
        private OrderedProducts products;

        /// <summary>
        /// Инициализатор класса Order.
        /// </summary>
        /// <param name="customerNumber"> Номер клиента. </param>
        /// <param name="products">  клиента. </param>
        public Order(int customerNumber, OrderedProducts products)
        {
            if (customerNumber <= 0)
            {
                throw new ArgumentException("Номера заказов начинаются с положительного числа.",
                    nameof(customerNumber));
            }

            if (products == null || products.Count == 0)
            {
                throw new ArgumentException("Клиент ничего не заказал.",
                    nameof(products));
            }

            this.customerNumber = customerNumber;
            this.products = products;
        }

        /// <summary>
        /// Номер клиента.
        /// </summary>
        public int CustomerNumber { get => customerNumber; }

        /// <summary>
        /// Продукция заказанная клиентам.
        /// </summary>
        public OrderedProducts Products { get => products; }
    }
}
