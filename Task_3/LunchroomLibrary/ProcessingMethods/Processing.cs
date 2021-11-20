using System;

namespace LunchroomLibrary
{
    /// <summary>
    /// Способ обработки продукта.
    /// </summary>
    public abstract class Processing
    {
        private ProcessingType processingType;
        private double duration;
        private double cost;

        /// <summary>
        /// Инициализатор класса Processing.
        /// </summary>
        /// <param name="processingType"> Вид обработки. </param>
        /// <param name="duration"> Длительность обработки. </param>
        /// <param name="cost"> Стоимость обработки. </param>
        public Processing(ProcessingType processingType, double duration, double cost)
        {          
            if (duration <= 0)
            {
                throw new ArgumentNullException("Длительность обработки указана не верно.", nameof(duration));
            }

            if (cost <= 0)
            {
                throw new ArgumentNullException("Стоимость обработки указана не верно.", nameof(cost));
            }

            this.processingType = processingType;
            this.duration = duration;
            this.cost = cost;
        }

        /// <summary>
        /// Вид обработки.
        /// </summary>
        public ProcessingType ProcessingType { get => processingType; }

        /// <summary>
        /// Длительность.
        /// </summary>
        public double Duration { get => duration; }

        /// <summary>
        /// Стоимость.
        /// </summary>
        public double Cost { get => cost; }

        /// <summary>
        /// Обработать ингридиент.
        /// </summary>
        /// <param name="ingridient"> Ингридиент. </param>
        public void Process(ref Ingridient ingridient)
        {

        }
    }
}
