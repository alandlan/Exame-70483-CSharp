using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos
{
    public  class Cliente
    {
        /// <summary>
        /// Id do cliente.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// CPF do cliente
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Email do cliente
        /// </summary>
        public string Email { get; set; }
    }
}
