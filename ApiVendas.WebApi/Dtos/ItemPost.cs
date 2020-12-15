using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.WebApi.Dtos
{
    public class ItemPost
    {
        /// <summary>
        /// Identificador do item
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Nome do item
        /// </summary>
        public string Nome { get; set; }
    }
}
