using System;
using System.Collections.Generic;

namespace tööobjekt_orjent
{
    internal class Tab
    {
        public IList<double> Entries { get; private set; } = new List<double>();

        internal void Add(double price)
        {
            Entries.Add(price);
        }
    }
}