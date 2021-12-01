using System;
using System.Collections.Generic;

namespace LunchroomLibrary
{
    /// <summary>
    /// Последовательность приготовления.
    /// </summary>
    public class CookingSequence : GenericList<object>
    {
        /// <summary>
        /// Добавить ингридиент или способ обработки.
        /// </summary>
        /// <param name="obj"> Объект. </param>
        public override void AddObject(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException($"{this.GetType().Name} не был передан.");
            }

            if ( !(obj is Ingridient) && !(obj is Processing) )
            {
                throw new ArgumentNullException($"Последовательность приготовления не может содержать переданный объект.");
            }

            list.Add(obj);
        }
    }
}
