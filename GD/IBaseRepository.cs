using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1Bim.GD
{
    public interface IBaseGD<T> where T : class
    {
        T RecuperarPorId(int id);
        IQueryable<T> RecuperarTodos();
        void Adicionar(T item);
        void Remover(T item);
        void Editar(T item);
    }
}
