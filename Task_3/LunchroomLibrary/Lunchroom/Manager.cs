using System;
using System.Collections.Generic;

namespace LunchroomLibrary
{
    /// <summary>
    /// Менеджер.
    /// </summary>
    public class Manager
    {
        private int account;

        /// <summary>
        /// Инициализатор класса Manager.
        /// </summary>
        public Manager()
        {
            account = 1;
            Orders = new List<Order>();
        }

        /// <summary>
        /// Заказы.
        /// </summary>
        public List<Order> Orders { get; }

        /// <summary>
        /// Принять заказ.
        /// </summary>
        /// <param name="products"> Заказанная продукция. </param>
        public void AcceptTheOrder(OrderedProducts products)
        {
            if (products == null)
            {
                throw new ArgumentException("Клиент ничего не заказал.",
                    nameof(products));
            }

            Orders.Add(new Order(account, products));
            account++;
        }
    }
}
