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
        /// Способы обработки.
        /// </summary>
        public List<Processing> ProcessingMethods { get => List; }

        /// <summary>
        /// Стоимость обработки.
        /// </summary>
        public double ProcessingCost { get => CalculateProcessingCost(); }

        /// <summary>
        /// Время обработки.
        /// </summary>
        public double ProcessingTime { get => CalculateProcessingTime(); }

        /// <summary>
        /// Посчитать стоимость обработки.
        /// </summary>
        /// <returns> Возвращает стоимость обработки. </returns>
        private double CalculateProcessingCost()
        {
            double cost = 0;

            foreach (Processing processing in list)
            {
                cost += processing.Cost;
            }

            return cost;
        }

        /// <summary>
        /// Посчитать время обработки.
        /// </summary>
        /// <returns> Возвращает время обработки. </returns>
        private double CalculateProcessingTime()
        {
            double time = 0;

            foreach (Processing processing in list)
            {
                time += processing.Duration;
            }

            return time;
        }
    }
}
