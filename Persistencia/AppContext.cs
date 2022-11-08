using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Trabajito.Dominio;

namespace Trabajito.Persistencia
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("conexion") { }
        public DbSet<Persona> Personas { get; set; }
    }
}