using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCorpSafe.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo Requerido")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="El Nombre Debe Tener de 3 a 50 Caracterres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public bool Casado { get; set; }        
        public int Mes { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int Sexo { get; set; }
    }

    public enum Meses
    {
        Enero = 1,
        Febrero = 2,
        Marzo = 3,
        Abril = 4,
        Mayo = 5,
        Junio = 6,
        Julio = 7,
        Agosto = 8,
        Septiembre = 9,
        Octubre = 10,
        Noviembre = 11,
        Diciembre = 12
    }
}
