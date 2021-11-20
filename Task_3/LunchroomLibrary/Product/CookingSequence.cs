using System;
using System.Collections.Generic;

namespace LunchroomLibrary
{
    /// <summary>
    /// Последовательность приготовления.
    /// </summary>
    public class CookingSequence : GenericList<Processing>
    {
        /// <summary>
        /// Общая стоимость обработок.
        /// </summary>
        public double ProcessingsPrice
        {
            get { return CalculateProcessingsPrice(); }
        }
       
        /// <summary>
        /// Посчитать общую стоимость обработок.
        /// </summary>
        /// <returns> Возвращает общую стоимость обработок. </returns>
        private double CalculateProcessingsPrice()
        {
            double price = 0;

            foreach (Processing processing in list)
            {
                price += processing.Price;
            }

            return price;
        }
    }
}
