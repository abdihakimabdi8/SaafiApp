using System;
using System.Collections.Generic;
using SaafiApp.Core.Model;
namespace SaafiApp.Core.Contracts.Repository
{
    public interface ISettingsRepository
    {
        List<Currency> GetAvailableCurrencies();
        Currency GetCurrencyById(int currencyId);

        string GetAboutContent();
    }
}
