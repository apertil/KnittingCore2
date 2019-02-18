using System;
using System.Collections.Generic;

namespace KnittingCore2.Models
{
    public partial class GeneroEdad
    {
        public GeneroEdad()
        {
            Patrones = new HashSet<Patrones>();
        }

        public int IdGenEd { get; set; }
        public string GenEdad { get; set; }

        public ICollection<Patrones> Patrones { get; set; }
    }
}
