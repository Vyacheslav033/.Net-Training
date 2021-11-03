using System;


namespace TransportCompanyLibrary    
{
    /// <summary>
    /// Продукт питания.
    /// </summary>
    public abstract class Foodstuff : Product
    {
        private int minGradus;
        private int maxGradus;


        public Foodstuff(string name, int count, float weight, MeasureUnit measure, int minGradus, int maxGradus) : base(name, count, weight, measure)
        {
            if ( (minGradus > maxGradus) || (maxGradus < minGradus) )
            {
                throw new ArgumentException("Температура храниения продукта была указана не верно.");
            }

            this.minGradus = minGradus;
            this.maxGradus = maxGradus;

        }

        /// <summary>
        /// Минимальный градус хранения.
        /// </summary>
        public int MinGradus
        {
            get { return minGradus; }
        }

        /// <summary>
        /// Максимальный градус хранения.
        /// </summary>
        public int MaxGradus
        {
            get { return maxGradus; }
        }
    }
}
