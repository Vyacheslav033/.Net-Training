using System;
using System.Collections.Generic;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Груз.
    /// </summary>
    public class Cargo
    {
        private List<Product> cargo;

        /// <summary>
        /// Инициализатор класса Cargo.
        /// </summary>
        public Cargo()
        {
            cargo = new List<Product>();
        }

        /// <summary>
        /// Вес груза.
        /// </summary>
        public float Weight 
        {
            get { return CalculateWeight(); }
        }

        /// <summary>
        /// Добавить товар.
        /// </summary>
        /// <param name="product"> Товар. </param>
        public void AddProduct(Product product)
        {
            if (product != null)
            {
                cargo.Add(product);
            }
        }

        /// <summary>
        /// Удалить конкретный товар.
        /// </summary>
        /// <param name="product"> Товар. </param>
        public void RemoveProduct(Product product)
        {
            if (product != null)
            {
                for (var i = 0; i < cargo.Count; i++)
                {
                    if (cargo[i].Equals(product))
                    {
                        cargo.RemoveAt(i);
                    }
                }
            }
        }

        /// <summary>
        /// Удалить весь товар.
        /// </summary>
        public void RemoveAllProduct()
        {
            cargo.Clear();
        }

        /// <summary>
        /// Посчитать общий вес товара.
        /// </summary>
        /// <returns> Общий вес товара. </returns>
        private float CalculateWeight()
        {
            float weight = 0;

            foreach (Product product in cargo)
            {
                weight += product.Weight;
            }

            return weight;
        }
    }
}
