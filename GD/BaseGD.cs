using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.GD
{
    public class BaseGD<T> : IDisposable, IBaseGD<T> where T : class
    {
        public database1Entities1 _context;

        public BaseGD(database1Entities1 context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Adicionar(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public void Editar(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public T RecuperarPorId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> RecuperarTodos()
        {
            return _context.Set<T>();
        }

        public void Remover(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }
    }
}