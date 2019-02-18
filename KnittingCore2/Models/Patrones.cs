using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KnittingCore2.Models
{
    public partial class Patrones
    {
        
        public int IdNombrePatron { get; set; }
        

        [CustomTitleValidator]
        [DataType(DataType.Text)]
        [Display(Name = "Nombre Patron*")]
        public string NombrePatron { get; set; }

        [Display(Name = "Autor Patron")]
        public int? IdAutorPatron { get; set; }

        [Display(Name = "Lana")]
        public int? IdLana { get; set; }

        [Display(Name = "Prendas")]
        public int? IdPrendas { get; set; }

        [Display(Name = "Revistas")]
        public int? IdRevistas { get; set; }

        [Display(Name = "Tipos de Características")]
        public int? IdTiposCaract { get; set; }

        [Display(Name = "Tipos de Tejidos")]
        public int? IdTiposdeTejer { get; set; }

        [Display(Name = "GeneroEdad")]
        public int? IdGenEdad { get; set; }

        //[RegularExpression(@"^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.pdf)$")]
        [CustomTitleValidator]
        [Display(Name = "Patrón *")]
        public byte[] Patron { get; set; }

        public virtual AutorPatron AutorPatron { get; set; }
        public virtual GeneroEdad GeneroEdad { get; set; }
        public virtual Lanas Lanas { get; set; }
        public virtual Prendas Prendas { get; set; }
        public virtual Revistas Revistas { get; set; }
        public virtual TiposCaracteristicas TiposCaracteristicas { get; set; }
        public virtual TiposDeTejer TiposDeTejer { get; set; }
        
    }
}
