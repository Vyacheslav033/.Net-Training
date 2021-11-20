using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary
{
    /// <summary>
    /// Продукция закусочной.
    /// </summary>
    public class DinerProduct : Product
    {
        private Structure structure;
        private CookingSequence cookingSequence;
      

        /// <summary>
        /// Инициализатор класса DinerProduct.
        /// </summary>
        /// <param name="name"> Наименование ингридиента. </param>
        /// <param name="price"> Цена ингридиента. </param>
        public DinerProduct(string name, double price)
            : base(name, price)
        {
            structure = new Structure();
            cookingSequence = new CookingSequence();
        }

        /// <summary>
        /// Состав.
        /// </summary>
        public Structure Structure { get => structure; }


        /// <summary>
        /// Последовательность приготовления.
        /// </summary>
        public CookingSequence CookingSequence { get => cookingSequence; }

        public void Prepare()
        {

        }
    }
}
