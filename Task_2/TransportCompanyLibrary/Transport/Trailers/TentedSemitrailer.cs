using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Тентованный полуприцеп.
    /// </summary>
    public class TentedSemitrailer : Semitrailer
    {
        /// <summary>
        /// Инициализатор класса TentedSemitrailer.
        /// </summary>
        /// <param name="weight"> Вес. </param>
        /// <param name="loadCapacity"> Грузоподъёмность. </param>
        public TentedSemitrailer(float weight, int loadCapacity) : base(weight, loadCapacity)
        {

        }
    }
}
