using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace FMSystems.Cities.Rest.Api
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseMvc();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors()
                .AddMvcCore()
                .AddFormatterMappings()
                .AddJsonFormatters()
                .AddJsonOptions(options =>
                    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
                );
        }
    }
}
