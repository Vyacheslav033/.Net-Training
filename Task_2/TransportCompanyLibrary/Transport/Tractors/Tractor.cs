using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Седельный тягач.
    /// </summary>
    public class Tractor : Transport
    {
        protected Semitrailer semitrailer;

        /// <summary>
        /// Инициализатор класса Transport.
        /// </summary>
        /// <param name="mark"> Марка. </param>
        /// <param name="model"> Модель. </param>
        /// <param name="weight"> Вес. </param>
        /// <param name="enginePower"> Мощность двигателя. </param>
        /// <param name="loadCapacity"> Грузоподъёмность. </param>
        /// <param name="fuelConsumption"> Расход топлива. </param>
        public Tractor(string mark, string model, float weight, int enginePower, int loadCapacity, float fuelConsumption)
            : base(mark, model, weight, enginePower, loadCapacity, fuelConsumption)
        {
            // Можно добавить количество осей тягача, для расчёта правильной грузоподъёмности !!!

            semitrailer = null;
        }

        /// <summary>
        /// Прицеп.
        /// </summary>
        public Semitrailer Semitrailer 
        { 
            get { return semitrailer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Прицеп не был передан.");
                }

                // Изменить !!!
                if (value.Weight > loadCapacity)
                {
                    throw new ArgumentException("Грузоподъёмность тягача меньше чем вес прицепа.");
                }

                semitrailer = value;
            }
        }

        public override float Weight
        {
            // Изменить !!!
            get { return base.Weight; }
        }

        public override int LoadCapacity
        {
            // Изменить !!!
            get { return base.LoadCapacity; }
        }

        public override float GetConsumptionPerDistance(int km)
        {
            // Реализовать !!!
            return base.GetConsumptionPerDistance(km);
        }
    }
}
