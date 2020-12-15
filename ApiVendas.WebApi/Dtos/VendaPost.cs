using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.WebApi.Dtos
{
    public class VendaPost
    {
        /// <summary>
        /// Identificador da venda
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// vendedor responsavel pela venda
        /// </summary>
        public VendedorPost Vendedor { get; set; }
        /// <summary>
        /// Data que a venda foi realizada
        /// </summary>
        /// 
        public DateTime Data { get; set; }
        /// <summary>
        /// Itens da venda
        /// </summary>
        public IEnumerable<ItemPost> Itens { get; set; }
    }
}
