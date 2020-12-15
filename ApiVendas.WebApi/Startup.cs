using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using ApiVendas.Application;
using ApiVendas.TmdbAdapter;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Otc.AspNetCore.ApiBoot;
using Otc.Extensions.Configuration;

namespace ApiVendas.WebApi
{
    /// <summary>
    /// Este eh o Startup da API. 
    /// </summary>
    public class Startup : ApiBootStartup
    {
        protected override ApiMetadata ApiMetadata => new ApiMetadata()
        {
            Name = "ApiVendas",
            Description = "api",
            DefaultApiVersion = "1.0"
        };

        public Startup(IConfiguration configuration)
            : base(configuration)
        {

        }

        /// <summary>
        /// Registra os servicos especificos da API.
        /// </summary>
        /// <param name="services"></param>
        [ExcludeFromCodeCoverage]
        protected override void ConfigureApiServices(
            IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(TmdbMapperProfile),
                typeof(WebApiMapperProfile));

            services.AddTmdbAdapter(
                Configuration.SafeGet<TmdbAdapterConfiguration>());

            services.AddApplication
                (Configuration.SafeGet<ApplicationConfiguration>());
        }
    }
}
