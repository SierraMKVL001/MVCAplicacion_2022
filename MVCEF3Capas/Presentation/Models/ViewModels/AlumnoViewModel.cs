using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Entidades;

namespace Presentation.Models.ViewModels
{
    [MetadataType(typeof(AlumnoViewModel))]
    public partial class Alumnos 
    { 

    }

    public class AlumnoViewModel
    {

        public int id { get; set; }
        [Required(ErrorMessage ="Campo requerido")]
        [DisplayName("Nombre")]
        [MaxLength(60, ErrorMessage ="La longitud Maxima de {0} es {1}")]
        [MinLength(3, ErrorMessage ="La longitud Minima de {0} es de {1}")]
        [RegularExpression(@"^[A-Za-z\s]+$",ErrorMessage ="El {0} solo debe ser conformado por letras")]
        public string nombre { get; set; }
        [Required]
        [DisplayName("Primer Apellido")]
        [MaxLength(50, ErrorMessage = "La longitud Maxima de {0} es {1}")]
        [MinLength(3, ErrorMessage = "La longitud Minima de {0} es de {1}")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "El {0} solo debe ser conformado por letras")]
        public string primerApellido { get; set; }
        [DisplayName("Segundo Apellido")]
        [MaxLength(50, ErrorMessage = "La longitud Maxima de {0} es {1}")]
        [MinLength(3, ErrorMessage = "La longitud Minima de {0} es de {1}")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "El {0} solo debe ser conformado por letras")]
        public string segundoApellido { get; set; }
        [Required]
        [Display(Name ="Correo Electronico")]
        [EmailAddress]
        public string correo { get; set; }
        [Required, Display(Name ="Telefono")]
        [RegularExpression("[0-9]{10}")]
        public string telefono { get; set; }
        [Display(Name ="Fecha de Nacimiento")]
        [Required(ErrorMessage ="La {0} es requerida")]
        [Range(typeof(DateTime), "01 - 01 - 1990", "31 - 12 - 2000",ErrorMessage ="La edad no es la adecuada")]
        public System.DateTime fechaNacimiento { get; set; }
        [Display(Name ="CURP")]
        [Required(ErrorMessage ="La {0} es Requerida")]
        [RegularExpression("^([A-Z&]|[a-z&]{1})([AEIOU]|[aeiou]{1})([A-Z&]|[a-z&]{1})([A-Z&]|[a-z&]{1})([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])([HM]|[hm]{1})([AS|as|BC|bc|BS|bs|CC|cc|CS|cs|CH|ch|CL|cl|CM|cm|DF|df|DG|dg|GT|gt|GR|gr|HG|hg|JC|jc|MC|mc|MN|mn|MS|ms|NT|nt|NL|nl|OC|oc|PL|pl|QT|qt|QR|qr|SP|sp|SL|sl|SR|sr|TC|tc|TS|ts|TL|tl|VZ|vz|YN|yn|ZS|zs|NE|ne]{2})([^A|a|E|e|I|i|O|o|U|u]{1})([^A|a|E|e|I|i|O|o|U|u]{1})([^A|a|E|e|I|i|O|o|U|u]{1})([0-9]{2})$",ErrorMessage ="El Formato del {0} es incorrecto")]
        public string curp { get; set; }
        [DisplayName("Sueldo Mensual")]
        [Range(10000,40000,ErrorMessage ="El {0} debe ser mayor a {1} y menor a {2}")]
        [DataType(DataType.Currency)]
        public Nullable<decimal> sueldoMensual { get; set; }
        [DisplayName("Estado de Origen")]
        [Required]
        [Range(1,31,ErrorMessage ="El {0} debe estar entre {1} y {2}")]
        public int idEstadoOrigen { get; set; }
        [Display(Name ="Estatos del Alumno")]
        [Required]
        [Range(1,8,ErrorMessage ="El {0} debe estar entre Prospecto y Baja")]
        public short idEstatus { get; set; }

        public virtual Estados Estados { get; set; }
        public virtual EstatusAlumnos EstatusAlumnos { get; set; }
    }
}