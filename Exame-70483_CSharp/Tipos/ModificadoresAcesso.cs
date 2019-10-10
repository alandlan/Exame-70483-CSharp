using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos
{
    /// <summary>
    /// Modificadores de acesso do C#
    /// </summary>
    public class ModificadoresAcesso
    {
        /// <summary>
        /// Modificadore public o acesso não é restrito
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// É um modificador de acesso restrito, atributos e métodos 
        /// declarados com protected, são acessíveis somente pela classe declarada e suas subclasses
        /// </summary>
        protected string NomeProtegido {get; set;}
    }
}
