using System;

namespace LunchroomLibrary
{
    /// <summary>
    /// Способ обработки продукта.
    /// </summary>
    public abstract class Processing
    {
        public ProcessingType processingType;
        public double duration;
        public double price;

        /// <summary>
        /// Инициализатор класса Processing.
        /// </summary>
        /// <param name="processingType"> Вид обработки. </param>
        /// <param name="duration"> Длительность обработки. </param>
        /// <param name="price"> Стоимость обработки. </param>
        public Processing(ProcessingType processingType, double duration, double price)
        {          
            if (duration <= 0)
            {
                throw new ArgumentNullException("Длительность обработки указана не верно.", nameof(duration));
            }

            if (price <= 0)
            {
                throw new ArgumentNullException("Стоимость обработки указана не верно.", nameof(price));
            }

            this.processingType = processingType;
            this.duration = duration;
            this.price = price;
        }

        /// <summary>
        /// Вид обработки.
        /// </summary>
        public ProcessingType ProcessingType
        {
            get { return processingType; }
        }

        /// <summary>
        /// Длительность.
        /// </summary>
        public double Duration
        {
            get { return duration; }
        }

        /// <summary>
        /// Стоимость.
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Обработать ингридиент.
        /// </summary>
        /// <param name="ingridient"> Ингридиент. </param>
        public void Process(ref Ingridient ingridient)
        {

        }
    }
}
