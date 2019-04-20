namespace Sample.Domain
{
    public interface IPricingService
    {
        CurrencyAmount GetOverdraftThreshold(Currency currency);
        CurrencyAmount GetWelcomeBonus(Currency currency);
    }
}