using System;

namespace Sample.Domain
{
    [Serializable]
    public sealed class AddCustomerPayment : ICommand
    {
        public CustomerId Id { get; set; }
        public string Name { get; set; }
        public CurrencyAmount Amount { get; set; }

        public override string ToString()
        {
            return string.Format("Add {0} - '{1}'", Amount, Name);
        }
    }
}