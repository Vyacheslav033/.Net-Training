﻿using System;
using System.Collections.Generic;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Груз.
    /// </summary>
    public class Cargo
    {
        private List<Product> cargo;
        private int maxWeight;

        /// <summary>
        /// Инициализатор класса Cargo.
        /// </summary>
        /// <param name="maxWeight"> Максимальный вес груза. </param>
        public Cargo(Semitrailer semitrailer)
        {
           
            cargo = new List<Product>();

            this.maxWeight = semitrailer.LoadCapacity;
        }

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="index"> Индекс товара в списке. </param>
        /// <returns> Возвращает товар по указанному индексу. </returns>
        Product this[int index]
        {
            get
            { 
                if ( (index < 0) || (index > cargo.Count - 1) )
                {
                    throw new ArgumentException("Индекс выходит за пределы диапазона.", nameof(index));
                }

                return cargo[index];
            }
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
        /// <returns> Возвращает true если товар добавлен, в противном случае false. </returns>
        public bool AddProduct(Product product)
        {
            if (product == null)
            {
                return false;
            }

            if (maxWeight == 0)
            {
                cargo.Add(product);

                return true;
            }
            else if (CalculateWeight() + product.Weight <= maxWeight)
            {
                cargo.Add(product);

                return true;
            }

            return false;
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
        ///  Узнать имеет ли груз заданную категорию товара.
        /// </summary>
        /// <param name="type"> Категория товара. </param>
        /// <returns> Возвращает true если заданная категория товара имеется, в противном случае false. </returns>
        public bool IsThereProductCategory(Type type)
        {
            foreach (Product product in cargo)
            {
                if (product.GetType() == type)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Посчитать общий вес товара.
        /// </summary>
        /// <returns> Возвращает общий вес товара. </returns>
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