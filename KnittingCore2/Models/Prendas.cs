using System;
using System.Collections.Generic;

namespace KnittingCore2.Models
{
    public partial class Prendas
    {
        public Prendas()
        {
            Patrones = new HashSet<Patrones>();
        }

        public int IdPrendas { get; set; }
        public string NombrePrendas { get; set; }

        public ICollection<Patrones> Patrones { get; set; }
    }
}
