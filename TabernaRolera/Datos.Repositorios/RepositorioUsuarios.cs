using Datos.Nucleo;
using Datos.Nucleo.Repositorios;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Interfaces.Repositorios;

namespace Datos.Repositorios
{
    public class RepositorioUsuarios : RepositorioGenerico<Usuarios>, IRepositorioUsuario<Usuarios>
    {
        public RepositorioUsuarios(DbContext contextoDB) : base(contextoDB)
        {
        }
    }
}
