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

            this.weight = weight;
            this.loadCapacity = loadCapacity;

            cargo = new Cargo(this);
        }

        /// <summary>
        /// Груз.
        /// </summary>
        public Cargo Cargo 
        { 
            get { return cargo; }          
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

        /// <summary>
        /// Проверка на возможность догрузги товара с учётом различных видов прицепов.
        /// </summary>
        /// <param name="product"> Товар. </param>
        /// <returns> Возвращает true если товар можно догрузить, в противном случае false. </returns>
        public abstract bool CanAddProduct(Product product);

        /// <summary>
        /// Сравнение прицепов на равенство.
        /// </summary>
        /// <param name="obj"> Сравниваемый объект. </param>
        /// <returns> Возвращает true в случае равенства прицепов, в противном случае false. </returns>
        public override bool Equals(object obj)
        {
            if ((obj != null) || (obj.GetType() == this.GetType()))
            {
                Semitrailer s = (Semitrailer)obj;

                return (s.Weight == this.weight) && (s.LoadCapacity == this.loadCapacity);
                       
            }

            return false;
        }

        /// <summary>
        /// Получить HashCode объекта Semitrailer.
        /// </summary>
        /// <returns> HashCode объекта Semitrailer. </returns>
        public override int GetHashCode()
        {
            return weight.GetHashCode() ^ loadCapacity;
        }

        /// <summary>
        /// Информация о прицепе.
        /// </summary>
        /// <returns> Тип прицепа. </returns>
        public override string ToString()
        {
            return $" Semitrailer (Type: {this.GetType().Name}, " +
                $"Weight: {weight}, " +
                $"LoadCapacity {loadCapacity})";
        }
    }
}
