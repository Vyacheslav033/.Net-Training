using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary
{
    /// <summary>
    /// Производственная мощность.
    /// </summary>
    public class ProductionCapacity
    {
        private Dictionary<ProcessingType, int> productionMethods;

        /// <summary>
        /// Инициализатор класса ProductionCapacity.
        /// </summary>
        public ProductionCapacity()
        {
            productionMethods = new Dictionary<ProcessingType, int>();
        }
        
        /// <summary>
        /// Добавить метод производства.
        /// </summary>
        /// <param name="processingType"> Метод обработки. </param>
        /// <param name="count"> Количество разрешённого одновременного выполнения метода. </param>
        public void AddProductionMethods(ProcessingType processingType, int count)
        {
            if (productionMethods.ContainsKey(processingType))
            {
                productionMethods.Remove(processingType);
            }

            productionMethods.Add(processingType, count);
        }

        public int GetAllowedCount(ProcessingType processingType)
        {
            foreach (KeyValuePair<ProcessingType, int> keyValue in productionMethods)
            {
                if (keyValue.Key == processingType)
                {
                    return keyValue.Value;
                }
            }

            return -1;
        }
    }
}
