using Dominio.Interfaces.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorios
{
    public interface IRepositorio<TEntity> where TEntity : IEntidad 
    {
        TEntity ObtenerPorId(int id);
        List<TEntity> ObtenerPorExpresion(Expression<Func<TEntity, bool>> expresion);

        void Agregar(TEntity entidad);
        void Modificar(TEntity entidad);
        void Eliminar(TEntity entidad);

    }
}
