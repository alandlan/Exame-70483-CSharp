using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos
{
    public class Banco
    {
        /// <summary>
        /// Identificador unico da conta
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Numero da Conta
        /// </summary>
        public string NomeBanco { get; set; }

        /// <summary>
        /// Numero da conta
        /// </summary>
        public int NumeroConta { get; set; }

        /// <summary>
        /// Numero do digito
        /// </summary>
        public short NumeroDigito { get; set; }

        /// <summary>
        /// Numero da agencia
        /// </summary>
        public short NumeroAgencia { get; set; }

        /// <summary>
        /// Saldo Atual
        /// </summary>
        public decimal Saldo { get; set; }
    }
}
