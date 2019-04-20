using System;

namespace Sample.Domain
{
    [Serializable]
    public sealed class CreateCustomer : ICommand
    {
        public CustomerId Id { get; set; }
        public string Name { get; set; }
        public Currency Currency { get; set; }

        public override string ToString()
        {
            return string.Format("Create {0} named '{1}' with {2}", Id, Name, Currency);
        }
    }
}