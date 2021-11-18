using System;
using System.Collections.Generic;

namespace LunchroomLibrary
{
    /// <summary>
    /// Последовательность приготовления.
    /// </summary>
    public class CookingSequence
    {
        private List<Processing> processingMethods;

        /// <summary>
        /// Инициализатор класса CookingSequence.
        /// </summary>
        public CookingSequence()
        {
            processingMethods = new List<Processing>();
        }

        /// <summary>
        /// Количество способов обработки.
        /// </summary>
        public int MethodsCount
        {
            get { return processingMethods.Count; }
        }

        /// <summary>
        /// Общая стоимость обработок.
        /// </summary>
        public double ProcessingsPrice
        {
            get { return CalculateProcessingsPrice(); }
        }

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="index"> Индекс обработки в списке. </param>
        /// <returns> Возвращает обработу по указанному индексу. </returns>
        public Processing this[int index]
        {
            get
            {
                if ((index < 0) || (index > processingMethods.Count - 1))
                {
                    throw new ArgumentException("Индекс обработки выходит за пределы диапазона списка.", nameof(index));
                }

                return processingMethods[index];
            }
        }

        /// <summary>
        /// Добавить обработку.
        /// </summary>
        /// <param name="processing"> Способ обработки. </param>
        public void AddProcessing(Processing processing)
        {
            if (processing == null)
            {
                throw new ArgumentNullException("Способ обработки не был передан.");
            }

            processingMethods.Add(processing);
        }

        /// <summary>
        /// Удалить обработку по индексу.
        /// </summary>
        /// <param name="index"> Индекс обработки. </param>
        public void RemoveProcessingByIndex(int index)
        {
            if ((index < 0) || (index > processingMethods.Count - 1))
            {
                throw new ArgumentException("Индекс обработки выходит за пределы диапазона списка.", nameof(index));
            }

            processingMethods.RemoveAt(index);
        }

        /// <summary>
        /// Посчитать общую стоимость обработок.
        /// </summary>
        /// <returns> Возвращает общую стоимость обработок. </returns>
        private double CalculateProcessingsPrice()
        {
            double price = 0;

            foreach (Processing processing in processingMethods)
            {
                price += processing.Price;
            }

            return price;
        }
    }
}
