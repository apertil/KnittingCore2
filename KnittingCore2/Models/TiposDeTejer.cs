using System;
using System.Collections.Generic;

namespace KnittingCore2.Models
{
    public partial class TiposDeTejer
    {
        public TiposDeTejer()
        {
            Patrones = new HashSet<Patrones>();
        }

        public int IdTiposTejer { get; set; }
        public string NombreDeTejer { get; set; }

        public ICollection<Patrones> Patrones { get; set; }
    }
}
