using Dominio.Interfaces.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorios
{
    public interface IRepositorioUsuario<TEntity>: IRepositorio<TEntity> where TEntity : IEntidad
    {
    }
}
