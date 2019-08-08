namespace FMSystems.Cities.Services.Impl
{
    using System.Collections.Generic;
    using FMSystems.Cities.Dao;
    using FMSystems.Cities.Dao.Memory;
    using FMSystems.Cities.Domain.Models;

    public class CitiesService : ICitiesService
    {
        private ICitiesDao citiesDao;

        public CitiesService()
        {
            this.citiesDao = new CitiesDao();
        }

        public IList<City> GetCities()
        {
            return this.citiesDao.GetCities();
        }
    }
}
