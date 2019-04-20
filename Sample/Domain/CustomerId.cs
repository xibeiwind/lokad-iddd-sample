using System;

namespace Sample.Domain
{
    [Serializable]
    public sealed class CustomerId : IIdentity
    {
        public readonly long Id;

        public CustomerId(long id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return string.Format("customer-{0}", Id);
        }
    }
}