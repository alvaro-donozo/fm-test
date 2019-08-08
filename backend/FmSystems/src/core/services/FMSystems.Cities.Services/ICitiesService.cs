namespace FMSystems.Cities.Services
{
    using FMSystems.Cities.Domain.Models;
    using System.Collections.Generic;

    public interface ICitiesService
    {
        IList<City> GetCities();
    }
}
