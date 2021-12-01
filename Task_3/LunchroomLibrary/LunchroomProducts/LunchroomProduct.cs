using System;

namespace LunchroomLibrary
{
    /// <summary>
    /// Продукция закусочной.
    /// </summary>
    public abstract class LunchroomProduct
    {
        protected string name;

        /// <summary>
        /// Инициализатор класса LunchroomProduct.
        /// </summary>
        /// <param name="name"> Наименование продукции. </param>
        public LunchroomProduct(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название продукции не было указано.",
                    nameof(name));
            }

            this.name = name;

            Recipe = new Recipe();
        }

        /// <summary>
        /// Наименование продукции.
        /// </summary>
        public string Name { get => name; }

        /// <summary>
        /// Рецепт.
        /// </summary>
        public Recipe Recipe { get; set; }


        /// <summary>
        /// Время приготовления.
        /// </summary>
        public double CookingTime { get => Recipe.ProcessingMethods.ProcessingTime; }

        /// <summary>
        /// Стоимость приготовления.
        /// </summary>
        public double Cost { get => Recipe.ProcessingMethods.ProcessingCost + Recipe.Structure.IngredientsCost; }

        /// <summary>
        /// Иформация о продукции.
        /// </summary>
        /// <returns> Иформация о продукции. </returns>
        public override string ToString()
        {
            return $"{GetType().Name} ( " +
                   $"Name: {name}, " +
                   $"CookingTime: {CookingTime} minutes, " +
                   $"Cost: {Cost}$ )";
        }
    }
}
