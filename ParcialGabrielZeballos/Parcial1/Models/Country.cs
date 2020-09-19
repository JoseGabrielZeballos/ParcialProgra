using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1.Models
{
    public class Country
    {
        [Display(Name = "Las 3 primeras iniciales")]
        [StringLength(3,ErrorMessage ="El campo {0} debe de llenarse con las iniciales del pasis de {2} a {1}",MinimumLength =1)]
        public string alpha3Code { get; set; }
        [Display(Name = "Nombre del continente")]
        public string  region { get; set; }
        [Display (Name ="Nombre del pais")]

        public string name { get; set; }
        [Display(Name ="Colocar el area del pais")]

        public float area { get; set; }
        public int callingCodes { get; set; }
        public int languages { get; set; }
        public int flag { get; set; }


    }
}