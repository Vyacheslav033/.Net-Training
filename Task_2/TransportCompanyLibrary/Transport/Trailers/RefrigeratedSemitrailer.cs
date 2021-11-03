using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Полуприцеп рефрижератор.
    /// </summary>
    public class RefrigeratedSemitrailer : Semitrailer
    {
        /// <summary>
        /// Инициализатор класса RefrigeratedSemitrailer.
        /// </summary>
        /// <param name="weight"> Вес. </param>
        /// <param name="loadCapacity"> Грузоподъёмность. </param>
        public RefrigeratedSemitrailer(float weight, int loadCapacity) : base(weight, loadCapacity)
        {

        }
    }
}
