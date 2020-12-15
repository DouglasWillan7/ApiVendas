using System;
using System.Collections.Generic;
using System.Text;

namespace ApiVendas.Domain.Models
{
    public class Vendedor
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
