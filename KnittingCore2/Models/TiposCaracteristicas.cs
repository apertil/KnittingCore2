using System;
using System.Collections.Generic;

namespace KnittingCore2.Models
{
    public partial class TiposCaracteristicas
    {
        public TiposCaracteristicas()
        {
            Patrones = new HashSet<Patrones>();
        }

        public int IdTiposCaract { get; set; }
        public string NombreCaracteristicas { get; set; }

        public ICollection<Patrones> Patrones { get; set; }
    }
}
