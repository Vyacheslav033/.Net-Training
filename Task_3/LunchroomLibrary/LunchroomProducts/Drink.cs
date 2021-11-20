using System;

namespace LunchroomLibrary
{
    /// <summary>
    /// Напиток.
    /// </summary>
    public class Drink : LunchroomProduct
    {
        /// <summary>
        /// Инициализатор класса Drink
        /// </summary>
        /// <param name="name"> Наименование напитка. </param>
        public Drink(string name) : base(name) { }
    }
}
