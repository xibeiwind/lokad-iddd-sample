using Sample.Domain;

namespace Sample.Projections
{
    /// <summary>
    /// NB: this class is currently not wired to the infrastructure.
    /// See Lokad.CQRS Sample project for more details
    /// </summary>
    public class CustomerTransactionsProjection
    {
        readonly IDocumentWriter<CustomerId, CustomerTransactions> _store;
        public CustomerTransactionsProjection(IDocumentWriter<CustomerId, CustomerTransactions> store)
        {
            _store = store;
        }
        public void When(CustomerCreated e)
        {
            _store.Add(e.Id, new CustomerTransactions());
        }
        public void When(CustomerChargeAdded e)
        {
            _store.UpdateOrThrow(e.Id, v => v.AddTx(e.ChargeName, -e.Charge, e.NewBalance, e.TimeUtc));
        }
        public void When(CustomerPaymentAdded e)
        {
            _store.UpdateOrThrow(e.Id, v => v.AddTx(e.PaymentName, e.Payment, e.NewBalance, e.TimeUtc));
        }
    }
}