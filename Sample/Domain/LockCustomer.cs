using System;

namespace Sample.Domain
{
    [Serializable]
    public class LockCustomer : ICommand
    {
        public CustomerId Id { get; set; }
        public string Reason { get; set; }
    }
}