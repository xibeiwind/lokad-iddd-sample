using System;

namespace Sample.Domain
{
    [Serializable]
    public class CustomerCreated : IEvent
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public CustomerId Id { get; set; }
        public Currency Currency { get; set; }

        public override string ToString()
        {
            return string.Format("Customer {0} created with {1}", Name, Currency);
        }

    }
}