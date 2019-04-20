using System;

namespace Sample.Domain
{
    [Serializable]
    public sealed class CustomerPaymentAdded : IEvent
    {
        public CustomerId Id { get; set; }
        public string PaymentName { get; set; }
        public CurrencyAmount Payment { get; set; }
        public CurrencyAmount NewBalance { get; set; }
        public int Transaction { get; set; }
        public DateTime TimeUtc { get; set; }

        public override string ToString()
        {
            return string.Format("Added '{2}' {1} | Tx {0} => {3}", 
                Transaction, Payment, PaymentName, NewBalance);
        }
    }
}