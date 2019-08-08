namespace FMSystems.Cities.Services.Stub
{
    using System;
    using System.Collections.Generic;
    using FMSystems.Cities.Domain.Models;

    public class CitiesService : ICitiesService
    {
        private List<City> cities;

        public CitiesService()
        {
            this.PopulateCitiesList();
        }

        public IList<City> GetCities()
        {
            return this.cities;
        }

        private void PopulateCitiesList()
        {
            this.cities = new List<City>
            {
                new City
                {
                    Id = Guid.Parse("39793810-e0b4-45f2-a7a8-25ed84eec7f3"),
                    Name = "Phoenix",
                    State = "AZ"
                },
                new City
                {
                    Id = Guid.Parse("18ba2d82-2c0c-44bd-8ca9-78001064fcad"),
                    Name = "Raleigh",
                    State = "NC"
                }
            };
        }
    }
}
