using System;
using System.Collections.Generic;

namespace KnittingCore2.Models
{
    public partial class Revistas
    {
        public Revistas()
        {
            Patrones = new HashSet<Patrones>();
        }

        public int IdRevistas { get; set; }
        public string NombreRevista { get; set; }
        public string Autor { get; set; }
        public byte[] RevistaFisica { get; set; }

        public ICollection<Patrones> Patrones { get; set; }
    }
}
