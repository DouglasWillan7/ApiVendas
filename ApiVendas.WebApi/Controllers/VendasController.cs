using ApiVendas.Domain.Models;
using ApiVendas.WebApi.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Otc.AspNetCore.ApiBoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.WebApi.Controllers
{
    [ApiVersion("1.0")]
    public class VendasController : ApiController
    {
        private readonly IMapper mapper;

        public VendasController(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


        /// <summary>
        /// Grava uma venda no banco de dados em memoria.
        /// </summary>
        /// <param name="VendaPost">
        ///     Venda a ser gravada.
        /// </param>
        /// <response code="200">Gravado com sucesso.</response>
        /// <response code="400">
        ///     Parametros incorretos ou limite de utilização excedido.
        /// </response>
        /// <response code="500">Erro interno.</response>
        [HttpPost]
        public async Task<IActionResult> EvetuarVenda (VendaPost venda)
        {

            return Ok();
        }
    }
}
