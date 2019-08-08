namespace FMSystems.Cities.Dao
{
    using System.Collections.Generic;
    using FMSystems.Cities.Domain.Models;

    public interface ICitiesDao
    {
        IList<City> GetCities();
    }
}
