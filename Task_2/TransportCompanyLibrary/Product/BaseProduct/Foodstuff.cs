using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Продукт питания.
    /// </summary>
    public abstract class Foodstuff : ProductWithThermalCondition
    {
        public Foodstuff(string name, int count, MeasureUnit measure, float weight, int minGradus, int maxGradus)
            : base(name, count, measure, weight, minGradus, maxGradus)
        { }
    }
}
