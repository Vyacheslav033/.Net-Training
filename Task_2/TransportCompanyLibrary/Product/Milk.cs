using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Молоко.
    /// </summary>
    public class Milk : Foodstuff
    {
        public Milk(string name, int count, MeasureUnit measure, float weight, int minGradus, int maxGradus)
            : base(name, count, measure, weight, minGradus, maxGradus)
        { }
    }
}
