using System;
using Sample.Domain;

namespace Sample.Projections
{
    [Serializable]
    public class CustomerTransaction
    {
        public CurrencyAmount Change;
        public CurrencyAmount Balance;
        public string Name;
        public DateTime TimeUtc;
    }
}