using System;
using System.Collections.Generic;

namespace LunchroomLibrary
{
    /// <summary>
    /// Состав.
    /// </summary>
    public class Structure : GenericList<Ingridient>
    {
        /// <summary>
        /// Цена всех ингридиентов состава.
        /// </summary>
        public double TotalPrice
        {
            get { return CalculateIngridientsPrice(); }
        }


        /// <summary>
        /// Посчитать общую цену ингридиентов.
        /// </summary>
        /// <returns> Возвращает общую цену ингридиентов. </returns>
        private double CalculateIngridientsPrice()
        {
            double price = 0;

            foreach (Ingridient ingridient in list)
            {
                price += ingridient.Price;
            }

            return price;
        }
    }
}
