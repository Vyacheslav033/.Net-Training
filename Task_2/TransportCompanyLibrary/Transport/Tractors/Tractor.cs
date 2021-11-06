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
        /// <param name="mileage"> Пробег. </param>
        /// <param name="loadCapacity"> Грузоподъёмность. </param>
        /// <param name="fuelType"> Вид топлива. </param>
        /// <param name="fuelConsumption"> Расход топлива. </param>
        public Tractor(string mark, string model, float weight, int enginePower, int mileage, int loadCapacity, FuelType fuelType, float fuelConsumption)
            : base(mark, model, weight, enginePower, mileage, loadCapacity, fuelType, fuelConsumption)
        {
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

                if (value.WeightWithCargo > loadCapacity)
                {
                    throw new ArgumentException("Грузоподъёмность тягача меньше чем вес прицепа.");
                }

                semitrailer = value;
            }
        }

        /// <summary>
        /// Вес тягача с прицепом.
        /// </summary>
        public float WeightWithTrailer
        {
            get
            {
                float trailerWeight = (semitrailer == null) ? 0 : semitrailer.WeightWithCargo;

                return weight + trailerWeight;
            }
        }

        /// <summary>
        /// Расчитать расход топлива фуры на расстояние.
        /// </summary>
        /// <param name="km"> Расход на расстояние. </param>
        /// <returns> Значение расхода топлива. </returns>
        public override float GetConsumptionPerDistance(int km)
        {          
            if (km < 1)
            {
                return 0;
            }

            // Норма расхода топлив на дополнительную массу прицепа.
            double norma = 1;

            // Вес прицепа.
            double semW = (semitrailer == null) ? 1 : semitrailer.Weight / 1000;

            // Вес груза.
            double cargoW = (semitrailer == null) ? 1 : semitrailer.Cargo.Weight / 1000;

            if (fuelType == FuelType.Gasolin) { norma = 2; }               
            else if (fuelType == FuelType.Diesel) { norma = 1.3; }      
            else if (fuelType == FuelType.Gas) { norma = 2.3; }

            // Норма расхода топлив на пробег фуры с прицепом без груза.
            double hsan = fuelConsumption + semW  * norma;

            // Нормативное значение расхода топлива для фуры.
            float qh = (float) (( (hsan * mileage) + (norma * cargoW * km) ) * 0.01);

            return qh;
        }
    }
}
