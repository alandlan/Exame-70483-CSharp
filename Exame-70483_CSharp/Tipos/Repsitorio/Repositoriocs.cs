using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipos;

namespace Tipos.Repsitorio
{
    /// <summary>
    /// Essa classe faz as ações de acesso a dados
    /// </summary>
    public class Repositoriocs
    {
        /// <summary>
        /// Interface genérica utilizada para todas as classes
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        public interface IBaseGeneric<TEntity> where TEntity : class
        {
            int Delete();
            TEntity Salvar(TEntity entity);
            TEntity Atualiza(TEntity entity);
            IList<TEntity> Litar();
            TEntity GetById(int id);
        }


        /// <summary>
        /// ContaCorrente herda a classe genérica
        /// </summary>
        public class ContaRepositorio
        {
            Conta conta = new Conta();
        }

        
    }
}
