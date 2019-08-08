namespace FMSystems.Cities.Dao.Memory
{
    using System;
    using System.Collections.Generic;
    using FMSystems.Cities.Domain.Models;

    public class CitiesDao : ICitiesDao
    {
        private List<City> cities;

        public CitiesDao()
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
                    Id = Guid.Parse("573f0e0c-7987-420a-b885-346cbf2972ab"),
                    Name = "Phoenix",
                    State = "AZ"
                },
                new City
                {
                    Id = Guid.Parse("fe55d066-e1db-4996-8038-0a517536066b"),
                    Name = "Raleigh",
                    State = "NC"
                },
                new City
                {
                    Id = Guid.Parse("04b1b89d-297d-4cad-aa1b-ad2b96cef5c9"),
                    Name = "Saint John",
                    State = "NB"
                },
                new City
                {
                    Id = Guid.Parse("2666a649-900a-4e9b-9739-431858a68916"),
                    Name = "San Diego",
                    State = "CA"
                }
            };
        }
    }
}
