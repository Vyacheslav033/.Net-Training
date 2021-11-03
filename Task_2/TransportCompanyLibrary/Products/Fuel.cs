using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Топливо.
    /// </summary>
    public class Fuel : Product
    {
        private FuelType fuelType;


        public Fuel(string name, int count, float weight, MeasureUnit measure, FuelType fuelType) : base(name, count, weight, measure)
        {
            this.fuelType = fuelType;
        }


        public FuelType FuelType
        { 
            get { return fuelType; }
        }


    }
}
