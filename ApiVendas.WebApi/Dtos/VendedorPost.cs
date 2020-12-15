using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.WebApi.Dtos
{
    public class VendedorPost
    {

        /// <summary>
        /// identificador do vendedor
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Cpf do vendedor
        /// </summary>
        public long Cpf { get; set; }
        /// <summary>
        /// Email do vendedor
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Telefone do vendedor
        /// </summary>
        public long Telefone { get; set; }
    }
}
