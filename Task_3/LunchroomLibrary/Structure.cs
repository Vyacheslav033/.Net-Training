using System;
using System.Collections.Generic;

namespace LunchroomLibrary
{
    /// <summary>
    /// Состав.
    /// </summary>
    public class Structure
    {
        private List<Ingridient> ingredients;

        /// <summary>
        /// Инициализатор класса Structure.
        /// </summary>
        public Structure( )
        {          
            ingredients = new List<Ingridient>();
        }

        /// <summary>
        /// Количество ингридиентов.
        /// </summary>
        public int IngridientsCount
        {
            get { return ingredients.Count; }
        }

        /// <summary>
        /// Цена всех ингридиентов состава.
        /// </summary>
        public double TotalPrice
        {
            get { return CalculateIngridientsPrice(); }
        }

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="index"> Индекс ингридиента в списке. </param>
        /// <returns> Возвращает ингридиент по указанному индексу. </returns>
        public Ingridient this[int index]
        {
            get
            {
                if ((index < 0) || (index > ingredients.Count - 1))
                {
                    throw new ArgumentException("Индекс ингридиента выходит за пределы диапазона списка.", nameof(index));
                }

                return ingredients[index];
            }
        }

        /// <summary>
        /// Добавить ингридиент.
        /// </summary>
        /// <param name="ingridient"> Товар. </param>
        public void AddIngridient(Ingridient ingridient)
        {
            if (ingridient == null)
            {
                throw new ArgumentNullException("Ингридиент не был передан.");
            }

            ingredients.Add(ingridient);
        }

        /// <summary>
        /// Удалить конкретный ингридиент.
        /// </summary>
        /// <param name="ingridient"> Ингридиент. </param>
        public void RemoveIngridient(Ingridient ingridient)
        {
            if (ingridient != null)
            {
                for (var i = 0; i < ingredients.Count; i++)
                {
                    if (ingredients[i].Equals(ingridient))
                    {
                        ingredients.RemoveAt(i);
                    }
                }
            }
        }

        /// <summary>
        /// Удалить ингридиент по индексу.
        /// </summary>
        /// <param name="index"> Индекс ингридиента. </param>
        public void RemoveProductByIndex(int index)
        {
            if ((index < 0) || (index > ingredients.Count - 1))
            {
                throw new ArgumentException("Индекс ингридиента выходит за пределы диапазона списка.", nameof(index));
            }

            ingredients.RemoveAt(index);
        }

        /// <summary>
        /// Удалить все ингридиенты.
        /// </summary>
        public void RemoveAllIngredients()
        {
            ingredients.Clear();
        }

        /// <summary>
        /// Посчитать общую цену ингридиентов.
        /// </summary>
        /// <returns> Возвращает общую цену ингридиентов. </returns>
        private double CalculateIngridientsPrice()
        {
            double price = 0;

            foreach (Ingridient ingridient in ingredients)
            {
                price += ingridient.Price;
            }

            return price;
        }
    }
}
