using System;

namespace Sample.Domain
{
    [Serializable]
    public class RenameCustomer : ICommand
    {
        public CustomerId Id { get; set; }
        public string NewName { get; set; }

        public override string ToString()
        {
            return string.Format("Rename {0} to '{1}'", Id, NewName);
        }
    }
}