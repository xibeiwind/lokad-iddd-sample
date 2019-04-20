using System;
using System.Collections.Generic;
using Sample.Domain;

namespace Sample.Projections
{
    [Serializable]
    public class CustomerTransactions
    {
        public IList<CustomerTransaction> Transactions = new List<CustomerTransaction>();
        public void AddTx(string name, CurrencyAmount change, CurrencyAmount balance, DateTime timeUtc)
        {
            Transactions.Add(new CustomerTransaction()
            {
                Name = name,
                Balance = balance,
                Change = change,
                TimeUtc = timeUtc
            });
        }
    }
}