using System.Collections.Generic;

namespace LunchroomLibrary
{
    /// <summary>
    /// Рецепт.
    /// </summary>
    public class Recipe
    {

        /// <summary>
        /// Инициализатор класса
        /// </summary>
        public Recipe()
        {
            Structure = new Structure();
            ProcessingMethods = new ProcessingMethods();
            CookingSequence = new CookingSequence();
        }

        /// <summary>
        /// Состав.
        /// </summary>
        public Structure Structure { get; set; }

        /// <summary>
        /// Методы обработки.
        /// </summary>
        public ProcessingMethods ProcessingMethods { get; set; }

        /// <summary>
        /// Последовательность приготовления.
        /// </summary>
        public CookingSequence CookingSequence { get; set; }

        /// <summary>
        /// Добавить ингридиент.
        /// </summary>
        /// <param name="ingridient"> Ингридиент. </param>
        public void AddIngredient(Ingridient ingridient)
        {
            Structure.AddObject(ingridient);
            CookingSequence.AddObject(ingridient);
        }

        /// <summary>
        /// Добавить метод обработки.
        /// </summary>
        /// <param name="processing"> Метод обработки. </param>
        public void AddProcessing(Processing processing)
        {
            ProcessingMethods.AddObject(processing);
            CookingSequence.AddObject(processing);
        }

      
    }
}
