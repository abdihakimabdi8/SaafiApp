using SaafiApp.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaafiApp.Core.Contracts.Services
{
   public interface ICityDataService
    {
        Task<List<City>> GetAllCities();

        Task<City> GetCityById(int cityId);
    }
}
