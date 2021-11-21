using System.Collections.Generic;

namespace LunchroomLibrary
{
    /// <summary>
    /// Продукция заказанная клиентам.
    /// </summary>
    public class OrderedProducts : GenericList<LunchroomProduct>
    {
        /// <summary>
        /// Продукция.
        /// </summary>
        public List<LunchroomProduct> Products { get => List; }
    }
}
