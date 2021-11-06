using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Химикаты.
    /// </summary>
    public abstract class Сhemicals : Product
    {
        public Сhemicals(string name, int count, MeasureUnit measure, float weight)
            : base(name, count, measure, weight)
        { }
    }
}
