using System;

namespace Sample.Domain
{
    [Serializable]
    public class CustomerRenamed : IEvent
    {
        public string Name { get; set; }
        // normally you don't need old name. But here, 
        // we include it just for demo
        public string OldName { get; set; }
        public CustomerId Id { get; set; }
        public DateTime Renamed { get; set; }

        public override string ToString()
        {
            return string.Format("Customer renamed from '{0}' to '{1}'", OldName, Name);
        }
    }
}