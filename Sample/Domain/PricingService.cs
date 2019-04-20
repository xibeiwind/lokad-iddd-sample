using System;

namespace Sample.Domain
{
    public sealed class PricingService : IPricingService
    {
        public CurrencyAmount GetOverdraftThreshold(Currency currency)
        {
            if (currency == Currency.Eur)
                return (-10m).Eur();
            throw new NotImplementedException("TODO: implement other currencies");
        }

        public CurrencyAmount GetWelcomeBonus(Currency currency)
        {
            if (currency == Currency.Eur)
                return 15m.Eur();
            throw new NotImplementedException("TODO: implement other currencies");
        }
    }
}