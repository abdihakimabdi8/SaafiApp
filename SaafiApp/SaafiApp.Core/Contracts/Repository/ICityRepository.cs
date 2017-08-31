using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaafiApp.Core.Model;

namespace SaafiApp.Core.Contracts.Repository
{
   public interface ICityRepository
    {
        Task<List<City>> GetAllCities();

        Task<City> GetCityById(int cityId);
    }
}

