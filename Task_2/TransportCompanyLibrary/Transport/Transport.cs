using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Транспортное средство.
    /// </summary>
    public abstract class Transport
    {
        protected string mark;
        protected string model;
        protected float weight;
        protected int enginePower;
        protected int loadCapacity;
        protected Fuel fuelType;
        protected float fuelConsumption;

        /// <summary>
        /// Инициализатор класса Transport.
        /// </summary>
        /// <param name="mark"> Марка. </param>
        /// <param name="model"> Модель. </param>
        /// <param name="weight"> Вес. </param>
        /// <param name="enginePower"> Мощность двигателя. </param>
        /// <param name="loadCapacity"> Грузоподъёмность. </param>
        /// <param name="fuelType"> Вид топлива. </param>
        /// <param name="fuelConsumption"> Расход топлива. </param>
        public Transport(string mark, string model, float weight, int enginePower, int loadCapacity, Fuel fuelType, float fuelConsumption)
        {
            if (String.IsNullOrWhiteSpace(mark))
            {
                throw new ArgumentException("Марка транспортного средства не была указана.");
            }

            if (String.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Модель транспортного средства не была указана.");
            }

            // Максимальный вес сравнил с белазом.
            if ( (weight < 600) || (weight > 400000) )
            {
                throw new ArgumentException("Транспортное средство не может иметь указанный вес.", nameof(weight));
            }

            if ( (enginePower <= 0) || (enginePower > 10000) )
            {
                throw new ArgumentException("Транспортное средство не может иметь указанную мощность двигателя.", nameof(enginePower));
            }

            // Максимальную грузоподъемность сравнил с белазом.
            if ((loadCapacity < 500) || (loadCapacity > 500000))
            {
                throw new ArgumentException("Транспортное средство не может иметь указанную грузоподъемность.", nameof(loadCapacity));
            }

            if ((fuelConsumption <= 0) || (fuelConsumption > 6000))
            {
                throw new ArgumentException("Транспортное средство не может иметь указанный расход топлива.", nameof(fuelConsumption));
            }

            this.mark = mark;
            this.model = model;
            this.weight = weight;
            this.enginePower = enginePower;
            this.loadCapacity = loadCapacity;
            this.fuelType = fuelType;
            this.fuelConsumption = fuelConsumption;
        }

        /// <summary>
        /// Марка.
        /// </summary>
        public string Mark
        {
            get { return mark; }
        }

        /// <summary>
        /// Модель.
        /// </summary>
        public string Model
        {
            get { return model; }
        }

        /// <summary>
        /// Вес кг.
        /// </summary>
        public virtual float Weight
        {
            get { return weight; }
        }  

        /// <summary>
        /// Мощность двигателя.
        /// </summary>
        public int EnginePower
        {
            get { return enginePower; }
        }

        /// <summary>
        /// Грузоподъёмность кг.
        /// </summary>
        public virtual int LoadCapacity
        {
            get { return loadCapacity; }
        }

        /// <summary>
        ///  Вид топлива.
        /// </summary>
        public Fuel FuelType
        {
            get { return fuelType; }
        }

        /// <summary>
        /// Расход топлива.
        /// </summary>
        public float FuelConsumption
        {
            get { return fuelConsumption; }
        }

        /// <summary>
        /// Расчитать расход топлива на расстояние.
        /// </summary>
        /// <param name="km"> Расстояние в км. </param>
        /// <returns> Расход топлива. </returns>
        public virtual float GetConsumptionPerDistance(int km)
        {
            // Реализовать !!!

            return 0;
        }
    }
}
