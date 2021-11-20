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

            Structure = new Structure();
            CookingSequence = new CookingSequence();
        }

        /// <summary>
        /// Наименование продукции.
        /// </summary>
        public string Name { get => name; }

        /// <summary>
        /// Состав.
        /// </summary>
        public Structure Structure { get; }

        /// <summary>
        /// Последовательность приготовления.
        /// </summary>
        public CookingSequence CookingSequence { get; }

        /// <summary>
        /// Время приготовления.
        /// </summary>
        public double CookingTime { get => CookingSequence.ProcessingTime; }

        /// <summary>
        /// Стоимость приготовления.
        /// </summary>
        public double Cost { get => CookingSequence.ProcessingCost + Structure.IngredientsCost; }

        /// <summary>
        /// Наименование продукции.
        /// </summary>
        /// <returns> Наименование продукции. </returns>
        public override string ToString()
        {
            return $"{GetType().Name} ( " +
                   $"Name: {name}, " +
                   $"CookingTime: {CookingTime} minutes, " +
                   $"Cost: {Cost}$ )";
        }
    }
}
