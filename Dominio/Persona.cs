using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajito.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }   
        public int Edad { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
    }
}