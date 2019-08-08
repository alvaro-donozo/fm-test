namespace FMSystems.Cities.Rest.Api.Controllers
{
    using FMSystems.Cities.Domain.Models;
    using FMSystems.Cities.Services;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [ApiController]
    [Route("api/v1/")]
    public class CitiesController : ControllerBase
    {
        private ICitiesService citiesService;

        public CitiesController(ICitiesService citiesService)
        {
            this.citiesService = citiesService;
        }

        [Route("cities")]
        [HttpGet]
        public ActionResult<IList<City>> GetCities()
        {
            var cities = this.citiesService.GetCities();
            return this.StatusCode(StatusCodes.Status200OK, cities);
        }
    }
}
