using MemoramaAPIWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoramaAPIWeb.Repositories
{
    public class PokeRepository<T> where T : class
    {

       public PokeDatos Context { get; set; }

        public PokeRepository(PokeDatos context)
        {
            Context = context;
        }

        //public virtual IEnumerable<T> GetAll()
        //{
        //    return Context.Set<T>();
        //}

        //public virtual T GetById(object id)
        //{
        //    return Context.Find<T>(id);
        //}

        //public virtual void Guardar()
        //{
        //    Context.SaveChanges();
        //}

        public virtual bool Validar(T entidad)
        {
            return false;
        }
    }
}
