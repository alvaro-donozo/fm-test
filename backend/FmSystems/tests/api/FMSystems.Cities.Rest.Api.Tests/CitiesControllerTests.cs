namespace FMSystems.Cities.Rest.Api.Tests
{
    using FMSystems.Cities.Rest.Api.Controllers;
    using FMSystems.Cities.Services.Stub;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Infrastructure;
    using Xunit;

    public class CitiesControllerTests
    {
        private CitiesController controller;

        public CitiesControllerTests()
        {
            this.controller = new CitiesController(new CitiesService());
        }

        [Fact]
        public void TestGetCities_ReturnsStatusCodeOK()
        {
            var actual = this.controller.GetCities().Result as IStatusCodeActionResult;
            var expected = StatusCodes.Status200OK;
            Assert.Equal(expected, actual.StatusCode);
        }

        [Fact]
        public void TestGetCities_ReturnsNonNullObject()
        {
            var actual = this.controller.GetCities().Result as ObjectResult;
            Assert.NotNull(actual);
        }
    }
}
