namespace Sample.Domain
{
    public static class CurrencyExtension
    {
        public static CurrencyAmount Eur(this decimal amount)
        {
            return new CurrencyAmount(amount, Currency.Eur);
        }
    }
}