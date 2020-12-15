using System;
using System.Collections.Generic;
using System.Text;

namespace ApiVendas.Domain.Models
{
    public class Item
    {
        /// <summary>
        /// Identificador do item
        /// </summary>
        public Guid Id{ get; set; }
        /// <summary>
        /// Nome do item
        /// </summary>
        public string Nome { get; set; }
    }
}
