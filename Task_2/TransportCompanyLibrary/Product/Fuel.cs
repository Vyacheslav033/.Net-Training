using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Топливо.
    /// </summary>
    public class Fuel : Product
    {
        public Fuel(string name, int count, MeasureUnit measure, float weight)
            : base(name, count, measure, weight)
        { }     
    }
}
