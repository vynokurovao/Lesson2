using System;
using System.Collections.Generic;

namespace HW_methods
{
    public class CurrencyConverter
    {
        private enum Currency { USD, RUB, PLN, EUR, UAH }

        private Dictionary<Currency, double> _mapFromCurrencyToUnit = new Dictionary<Currency, double>();
        private Dictionary<String, Currency> _mapFromStringToCurrency = new Dictionary<string, Currency>();

        public CurrencyConverter()
        {
            foreach (Currency currency in Enum.GetValues(typeof(Currency)))
            {
                _mapFromStringToCurrency.Add(currency.ToString(), currency);
            }

            _mapFromCurrencyToUnit.Add(Currency.USD, 24);
            _mapFromCurrencyToUnit.Add(Currency.EUR, 30);
            _mapFromCurrencyToUnit.Add(Currency.PLN, 22);
            _mapFromCurrencyToUnit.Add(Currency.RUB, 0.45);
            _mapFromCurrencyToUnit.Add(Currency.UAH, 1);
        }


        private Currency GetCurrencyByID(string currency)
        {
            if (!_mapFromStringToCurrency.ContainsKey(currency))
            {
                throw new ArgumentException("There is no such currency in this converter");
            }
            else
            {
                return _mapFromStringToCurrency[currency];
            }
        }


        public double convert(string currencyFrom, string currencyTo, double sum)
        {
            Currency CurrencyFrom = GetCurrencyByID(currencyFrom);
            Currency CurrencyTo = GetCurrencyByID(currencyTo);
            return sum * (_mapFromCurrencyToUnit[CurrencyFrom] / _mapFromCurrencyToUnit[CurrencyTo]);
        }
    }
}
