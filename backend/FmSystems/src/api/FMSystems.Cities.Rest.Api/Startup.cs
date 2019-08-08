namespace FMSystems.Cities.Rest.Api
{
    using FMSystems.Cities.Services;
    using FMSystems.Cities.Services.Impl;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseMvc();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICitiesService, CitiesService>();
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
