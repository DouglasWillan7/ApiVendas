using ApiVendas.Domain.Models;
using ApiVendas.Domain.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiVendas.Application
{
    public class VendaService : IVendasService
    {
        private readonly ApplicationConfiguration configuration;
        private readonly ILogger logger;


        public VendaService(ApplicationConfiguration
            configuration, ILoggerFactory loggerFactory)
        {
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            logger = loggerFactory?.CreateLogger<FilmesService>() ?? throw new ArgumentNullException(nameof(loggerFactory));
        }
        
        public Task GravaVenda(Venda venda)
        {
            throw new NotImplementedException();
        }
    }
}
