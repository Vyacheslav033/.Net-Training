using System;

namespace TransportCompanyLibrary
{
    /// <summary>
    /// Ртуть.
    /// </summary>
    public class Mercury : Сhemicals
    {
        public Mercury(string name, int count, MeasureUnit measure, float weight)
           : base(name, count, measure, weight)
        { }
    }
}
