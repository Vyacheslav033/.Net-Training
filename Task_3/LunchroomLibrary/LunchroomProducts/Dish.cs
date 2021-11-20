using System;

namespace LunchroomLibrary
{
    /// <summary>
    /// Блюдо.
    /// </summary>
    public class Dish : LunchroomProduct
    {
        /// <summary>
        /// Инициализатор класса Dish
        /// </summary>
        /// <param name="name"> Наименование блюда. </param>
        public Dish(string name) : base(name) { }
    }
}
