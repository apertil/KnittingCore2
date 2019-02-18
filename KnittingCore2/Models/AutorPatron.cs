using System;
using System.Collections.Generic;

namespace KnittingCore2.Models
{
    public partial class AutorPatron
    {
        public AutorPatron()
        {
            Patrones = new HashSet<Patrones>();
        }

        public int IdAutorPatron { get; set; }
        public string NombreAutor { get; set; }

        public ICollection<Patrones> Patrones { get; set; }
    }
}
