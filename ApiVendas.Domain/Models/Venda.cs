using Otc.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiVendas.Domain.Models
{
    public class Venda
    {
        /// <summary>
        /// Identificador da venda
        /// </summary>
        [Required(ErrorKey = "TermoPesquisaObrigatorio")]
        public Guid Id { get; set; }
        /// <summary>
        /// vendedor responsavel pela venda
        /// </summary>
        [Required(ErrorKey = "TermoPesquisaObrigatorio")]
        public Vendedor Vendedor { get; set; }
        /// <summary>
        /// Data que a venda foi realizada
        /// </summary>
        /// 
        [Required(ErrorKey = "TermoPesquisaObrigatorio")]
        public DateTime Data { get; set; }
        /// <summary>
        /// Itens da venda
        /// </summary>
        [Required(ErrorKey = "TermoPesquisaObrigatorio")]
        public IEnumerable<Item> Itens{get;set;}
    }
}
