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
        /// Ингридиенты.
        /// </summary>
        public List<Ingridient> Ingredients { get => List; }

        /// <summary>
        /// Стоимость ингридиентов.
        /// </summary>
        public double IngredientsCost { get => CalculateIngredientsCost(); }


        /// <summary>
        /// Посчитать стоимость ингридиентов.
        /// </summary>
        /// <returns> Возвращает стоимость ингридиентов. </returns>
        private double CalculateIngredientsCost()
        {
            double cost = 0;

            foreach (Ingridient ingridient in list)
            {
                cost += ingridient.Cost;
            }

            return cost;
        }
    }
}
