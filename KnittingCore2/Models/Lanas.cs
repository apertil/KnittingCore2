using System;
using System.Collections.Generic;

namespace KnittingCore2.Models
{
    public partial class Lanas
    {
        public Lanas()
        {
            Patrones = new HashSet<Patrones>();
        }

        public int IdLana { get; set; }
        public string NombreLana { get; set; }

        public ICollection<Patrones> Patrones { get; set; }
    }
}
