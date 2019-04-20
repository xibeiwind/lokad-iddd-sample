using System;

namespace Sample.Domain
{
    [Serializable]
    public sealed class CustomerChargeAdded : IEvent
    {
        public CustomerId Id { get; set; }
        public string ChargeName { get; set; }
        public CurrencyAmount Charge { get; set; }
        public CurrencyAmount NewBalance { get; set; }
        public int Transaction { get; set; }
        public DateTime TimeUtc { get; set; }

        public override string ToString()
        {
            return string.Format("Charged '{2}' {1} | Tx {0} => {3}",
                Transaction, Charge, ChargeName, NewBalance);
        }

    }
}