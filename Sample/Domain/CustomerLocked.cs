using System;

namespace Sample.Domain
{
    [Serializable]
    public class CustomerLocked : IEvent
    {
        public CustomerId Id { get; set; }
        public string Reason { get; set; }

        public override string ToString()
        {
            return string.Format("Customer locked: {0}", Reason);
        }
    }
}