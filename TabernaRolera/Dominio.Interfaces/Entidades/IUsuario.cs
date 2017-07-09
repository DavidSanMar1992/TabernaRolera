using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Entidades{
    public interface IUsuario:IEntidad{
        string Nombre { get; set; }
        string Contraseña { get; set; }
        string Email { get; set; }
        string Nick { get; set; }
    }
}
