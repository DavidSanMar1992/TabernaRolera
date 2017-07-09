using Dominio.Interfaces.Entidades;
using Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Nucleo.Repositorios
{
    public abstract class RepositorioGenerico<TEntity> : IRepositorio<TEntity> where TEntity : Entidad
    {
        DbContext contexto;
        DbSet<TEntity> set;
        public RepositorioGenerico(DbContext contextoDB)
        {
            contexto = contextoDB;
            set = contexto.Set<TEntity>();
        }
        public void Agregar(TEntity entidad)
        {
            set.Add(entidad); 
        }

        public void Eliminar(TEntity entidad)
        {
            if (contexto.Entry(entidad).State == EntityState.Detached)
                set.Attach(entidad);

            set.Remove(entidad);
        }

        public void Modificar(TEntity entidad)
        {
            set.Attach(entidad);
            contexto.Entry(entidad).State = EntityState.Modified;
        }

        public List<TEntity> ObtenerPorExpresion(Expression<Func<TEntity, bool>> expresion)
        {
            return set.Where(expresion).ToList();
        }

        public TEntity ObtenerPorId(int id)
        {
            return set.Where(w => w.Id == id).FirstOrDefault();
        }
    }
}
