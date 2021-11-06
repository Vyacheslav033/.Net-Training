using System;
using System.Collections.Generic;
using ProductLibrary;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Груз.
    /// </summary>
    public class Cargo
    {
        private List<Product> cargo;
        private Semitrailer semitrailer;

        /// <summary>
        /// Инициализатор класса Cargo.
        /// </summary>
        /// <param name="semitrailer"> Прицеп для груза. </param>
        public Cargo(Semitrailer semitrailer)
        {
            if (semitrailer == null)
            {
                throw new ArgumentNullException("Прицеп не был передан.");
            }

            this.semitrailer = semitrailer;

            cargo = new List<Product>();
        }

        /// <summary>
        /// Список товара.
        /// </summary>
        public List<Product> Product
        { 
            get { return cargo; }
        }

        /// <summary>
        /// Количество товара.
        /// </summary>
        public int ProductCount
        {
            get { return cargo.Count; }
        }

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="index"> Индекс товара в списке. </param>
        /// <returns> Возвращает товар по указанному индексу. </returns>
        public Product this[int index]
        {
            get
            { 
                if ( (index < 0) || (index > cargo.Count - 1) )
                {
                    throw new ArgumentException("Индекс товара выходит за пределы диапазона груза.", nameof(index));
                }

                return cargo[index];
            }
        }

        /// <summary>
        /// Тип прицепа хранящего груз.
        /// </summary>
        public Type SemitrailerType
        {
            get { return semitrailer.GetType(); }
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
            if ( product == null )
            {
                throw new ArgumentNullException("Товар не был передан.");
            }

            if ( !semitrailer.CanAddProduct(product) )
            {
                throw new ArgumentException("Данный тип прицепа не может перевозить передаваемый товар.");
            }

            if ( (CalculateWeight() + product.Weight) > semitrailer.LoadCapacity)
            {
                throw new ArgumentException("Товар на может быть добавлен, так как превышается грузоподъемность прицепа.");
            }

            cargo.Add(product);
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
        /// Удалить конкретный товар по индексу.
        /// </summary>
        /// <param name="index"> Индекс товара. </param>
        public void RemoveProductByIndex(int index)
        {
            if ((index < 0) || (index > cargo.Count - 1))
            {
                throw new ArgumentException("Индекс товара выходит за пределы диапазона груза.", nameof(index));
            }

            cargo.RemoveAt(index);
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
