﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Entidades
{
    public abstract class Entidad : IEntidad
    {
        public int Id { get; set;}
    }
}
