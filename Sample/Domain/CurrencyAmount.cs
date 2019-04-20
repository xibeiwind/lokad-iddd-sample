using System;

namespace Sample.Domain
{
    [Serializable]
    public struct CurrencyAmount
    {
        public readonly decimal Amount;
        public readonly Currency Currency;

        public CurrencyAmount(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }


        
        public static bool operator ==(CurrencyAmount left, CurrencyAmount right)
        {
            left.CheckCurrency(right.Currency, "==");
            return left.Amount == right.Amount;
        }

        public static bool operator !=(CurrencyAmount left, CurrencyAmount right)
        {
            left.CheckCurrency(right.Currency, "!=");
            return left.Amount != right.Amount;
        }
        public static bool operator < (CurrencyAmount left, CurrencyAmount right)
        {
            left.CheckCurrency(right.Currency, "<");
            return left.Amount < right.Amount;
        }

        public static CurrencyAmount operator + (CurrencyAmount left, CurrencyAmount right)
        {
            left.CheckCurrency(right.Currency, "+");
            return new CurrencyAmount(left.Amount + right.Amount, left.Currency);
        }
        public static CurrencyAmount operator -(CurrencyAmount left, CurrencyAmount right)
        {
            left.CheckCurrency(right.Currency, "-");
            return new CurrencyAmount(left.Amount - right.Amount, left.Currency);
        }
        public static CurrencyAmount operator -(CurrencyAmount right)
        {
            
            return new CurrencyAmount(- right.Amount, right.Currency);
        }

        void CheckCurrency(Currency type, string operation)
        {
            if (Currency == type) return;
            throw new InvalidOperationException(string.Format("Can't perform operation on different currencies: {0} {1} {2}", Currency, operation, type));
        }

        public static bool operator >(CurrencyAmount left, CurrencyAmount right)
        {
            left.CheckCurrency(right.Currency, ">");
            return left.Amount > right.Amount;
        }

        public override string ToString()
        {
            return string.Format("{0:0.##} {1}", Amount, Currency.ToString().ToUpper());
        }
    }
}