using System;

namespace LunchroomLibrary
{
    /// <summary>
    /// Способ обработки продукта.
    /// </summary>
    public class Processing
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
        public void Process(Ingridient ingridient)
        {

        }

        /// <summary>
        /// Сравнение способа обработки на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Возвращает true в случае равенства объектов, в противном случае false. </returns>
        public override bool Equals(object obj)
        {
            if ((obj != null) && (obj.GetType() == GetType()))
            {
                Processing p = (Processing)obj;

                return (processingType == p.ProcessingType) && (duration == p.Duration) && (cost == p.Cost);
            }

            return false;
        }

        /// <summary>
        /// Получить HashCode объекта Processing.
        /// </summary>
        /// <returns> HashCode объекта Processing. </returns>
        public override int GetHashCode()
        {
            return processingType.GetHashCode() ^ duration.GetHashCode() ^ cost.GetHashCode();
        }

        /// <summary>
        /// Информация об обработке.
        /// </summary>
        /// <returns> Информация об обработке. </returns>
        public override string ToString()
        {
            return $"{GetType().Name} ( " +
                   $"Type: {processingType}, " +
                   $"Duration: {duration}, " +
                   $"Cost: {cost} )";
        }
    }
}
