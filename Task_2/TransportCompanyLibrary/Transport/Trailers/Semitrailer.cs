using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Прицеп.
    /// </summary>
    public abstract class Semitrailer
    {
        protected float ownWeight;
        protected int loadCapacity;
        protected Cargo cargo;

        /// <summary>
        /// Инициализатор класса Semitrailer.
        /// </summary>
        /// <param name="weight"> Вес. </param>
        /// <param name="loadCapacity"> Грузоподъёмность. </param>
        public Semitrailer(float weight, int loadCapacity)
        {
            if ((weight < 200) || (weight > 20000))
            {
                throw new ArgumentException("Прицеп не может иметь указанный вес.", nameof(weight));
            }

            if ((loadCapacity < 200) || (loadCapacity > 20000))
            {
                throw new ArgumentException("Прицеп не может иметь указанную грузоподъемность.", nameof(loadCapacity));
            }

            this.ownWeight = weight;
            this.loadCapacity = loadCapacity;

            cargo = new Cargo();
        }

        /// <summary>
        /// Груз.
        /// </summary>
        public Cargo Cargo 
        { 
            get { return cargo; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Груз не может быть пустым.");
                }

                if (value.Weight > loadCapacity)
                {
                    throw new ArgumentException("Грузоподъёмность прицепа меньше чем вес груза.");
                }

                cargo = value;
            }
        }

        /// <summary>
        /// Общий вес с грузом, кг.
        /// </summary>
        public float Weight
        {
            get
            {
                return ownWeight + cargo.Weight;
            }
        }

        /// <summary>
        /// Грузоподъёмность кг.
        /// </summary>
        public int LoadCapacity
        {
            get { return loadCapacity; }
        }
    }
}
