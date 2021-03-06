﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SaafiApp.Core.Contracts.Repository;
using SaafiApp.Core.Contracts.Services;
using SaafiApp.Core.Model;

namespace SaafiApp.Core.Services.Data
{
    public class CityDataService : ICityDataService
    {
        private readonly ICityRepository _cityRepository;
        public CityDataService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public virtual async Task<List<City>> GetAllCities()
        {
            return await _cityRepository.GetAllCities();
        }

        public async Task<City> GetCityById(int cityId)
        {
            return await _cityRepository.GetCityById(cityId);
        }
    }
}