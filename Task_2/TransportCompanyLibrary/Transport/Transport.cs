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
        protected int mileage;
        protected int loadCapacity;
        protected FuelType fuelType;
        protected float fuelConsumption;

        /// <summary>
        /// Инициализатор класса Transport.
        /// </summary>
        /// <param name="mark"> Марка. </param>
        /// <param name="model"> Модель. </param>
        /// <param name="weight"> Вес. </param>
        /// <param name="enginePower"> Мощность двигателя. </param>
        /// <param name="mileage"> Пробег. </param>
        /// <param name="loadCapacity"> Грузоподъёмность. </param>
        /// <param name="fuelType"> Вид топлива. </param>
        /// <param name="fuelConsumption"> Расход топлива. </param>
        public Transport(string mark, string model, float weight, int enginePower, int mileage, int loadCapacity, FuelType fuelType, float fuelConsumption)
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

            if (mileage < 0)
            {
                throw new ArgumentException("Транспортное средство не может иметь указанный пробег.", nameof(mileage));
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
            this.mileage = mileage;
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
        public float Weight
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
        /// Пробег.
        /// </summary>
        public int Mileage
        {
            get { return mileage; }
        }

        /// <summary>
        /// Грузоподъёмность кг.
        /// </summary>
        public int LoadCapacity
        {
            get { return loadCapacity; }
        }

        /// <summary>
        ///  Вид топлива.
        /// </summary>
        public FuelType FuelType
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
        /// <returns> Значение расход топлива. </returns>
        public virtual float GetConsumptionPerDistance(int km)
        {
            if (km < 1)
            {
                return 0;
            }

            return (fuelConsumption * mileage) / km;
        }

        /// <summary>
        /// Сравнение транспортного средства на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Возвращает true в случае равенства транспорта, в противном случае false. </returns>
        public override bool Equals(object obj)
        {
            if ((obj != null) || (obj.GetType() == this.GetType()))
            {
                Transport p = (Transport) obj;

                return (p.Mark == this.mark) && (p.Model == this.model) &&
                       (p.Weight == this.weight) && (p.EnginePower == this.enginePower) &&
                       (p.Mileage == this.mileage) && (p.LoadCapacity == this.loadCapacity) &&
                       (p.FuelType == this.fuelType) && (p.FuelConsumption == this.fuelConsumption);
            }

            return false;
        }

        /// <summary>
        /// Получить HashCode объекта Transport.
        /// </summary>
        /// <returns> HashCode объекта Transport. </returns>
        public override int GetHashCode()
        {
            return mark.GetHashCode() ^ model.GetHashCode() ^ weight.GetHashCode() ^
                   enginePower ^ mileage ^ loadCapacity ^
                   fuelType.GetHashCode() ^ FuelConsumption.GetHashCode();
        }

        /// <summary>
        /// Характеристики транспортного средства.
        /// </summary>
        /// <returns> Характеристики транспортного средства. </returns>
        public override string ToString()
        {
            return $"{this.GetType().Name} (" +
                   $"Mark: {mark}, " +
                   $"Model: {model}, " +
                   $"Weight: {weight}, " +
                   $"EnginePower: {enginePower}, " +
                   $"Mileage: {mileage}, " +
                   $"LoadCapacity: {loadCapacity}, " +
                   $"FuelType: {fuelType}, " +
                   $"FuelConsumption: {fuelConsumption})";
        }
    }
}
