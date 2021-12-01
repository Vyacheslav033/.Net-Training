using System;

namespace LunchroomLibrary
{
    /// <summary>
    /// Шеф-повар.
    /// </summary>
    public class Chef
    {
        /// <summary>
        /// Приготовить блюдо/напиток.
        /// </summary>
        /// <param name="product"> Блюдо/напиток. </param>
        public void Prepare(LunchroomProduct product)
        {
            for (var i = 0; i < product.Recipe.CookingSequence.Count; i++)
            {
                if (product.Recipe.CookingSequence[i] is Processing)
                {
                    var processing = (Processing) product.Recipe.CookingSequence[i];

                    for (var j = i - 1; j >= 0; j--)
                    {
                        if (product.Recipe.CookingSequence[j] is Ingridient)
                        {
                            var ingridient = (Ingridient) product.Recipe.CookingSequence[j];

                            processing.Process(ingridient);
                        }
                    }
                }
            }
        }
    }
}
