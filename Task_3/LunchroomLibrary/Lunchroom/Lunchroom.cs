using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary
{
    /// <summary>
    /// Закусочная.
    /// </summary>
    public class Lunchroom
    {
        private StorageConditions storageConditions;
        private ProductionCapacity productionCapacity;

        public Lunchroom(StorageConditions storageConditions, ProductionCapacity productionCapacity)
        {
            if (storageConditions == null)
            {
                throw new ArgumentException("Условия хранения закусочной не были переданы.");
            }

            if (productionCapacity == null)
            {
                throw new ArgumentException("Производственная мощность закусочной не была указана.");
            }

            this.storageConditions = storageConditions;
            this.productionCapacity = productionCapacity;
        }

        public Chef Chef { get; }

        public Manager Manager { get; }
    }
}
