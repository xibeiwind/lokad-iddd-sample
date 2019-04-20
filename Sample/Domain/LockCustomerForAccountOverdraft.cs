using System;

namespace Sample.Domain
{
    [Serializable]
    public class LockCustomerForAccountOverdraft : ICommand
    {
        public CustomerId Id { get; set; }
        public string Comment { get; set; }
    }
}