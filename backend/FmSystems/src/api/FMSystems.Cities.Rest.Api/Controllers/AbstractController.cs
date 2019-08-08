namespace FMSystems.Cities.Rest.Api.Controllers
{
    using System;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    public class AbstractController : ControllerBase
    {
        public ActionResult<T> ExecuteRequest<T>(Func<T> request, int statusCode)
        {
            try
            {
                var result = request.Invoke();
                return this.StatusCode(statusCode, result);
            }
             catch (Exception e)
            {
                Console.WriteLine($"There is a problem with the api: ", e);
                return this.StatusCode(StatusCodes.Status500InternalServerError, "There is a problem with the service");
            }
        }
    }
}
