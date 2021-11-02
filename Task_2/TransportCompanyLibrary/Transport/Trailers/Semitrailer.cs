using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Прицеп.
    /// </summary>
    public abstract class Semitrailer
    {
        protected float weight;
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

            cargo = new Cargo(loadCapacity);

            this.weight = weight;
            this.loadCapacity = loadCapacity;
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
        /// Вес прицепа, кг.
        /// </summary>
        public float Weight
        {
            get { return weight; }
        }

        /// <summary>
        /// Общий вес с грузом, кг.
        /// </summary>
        public float WeightWithCargo
        {
            get { return weight + cargo.Weight; }
        }

        /// <summary>
        /// Грузоподъёмность, кг.
        /// </summary>
        public int LoadCapacity
        {
            get { return loadCapacity; }
        }
    }
}
