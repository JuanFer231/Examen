using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Pacientes.Models
{
    public class Paciente
    {
        [Key]

        public int PacienteId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe de tener mas de 3 caracteres.")]
        public string PacienteNombre { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Segundo Nombre")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe de tener mas de 3 caracteres.")]
        public string PacientePrimerApellido { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [Display(Name = "Apellidos")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe de tener mas de 3 caracteres.")]

        public string PacienteSegundoApellido { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Correo")]

        public string PacienteCorreo { get; set; }

        [Display(Name = "Nombre del acompañante")]
        public string PacineteAcompananteNombre { get; set; }

        [Display(Name = "Apellido del acompañante")]

        public string PacienteAcompananteApellido{ get; set; }

        [Required(ErrorMessage = "La direccion es requerida")]
        [Display(Name = "calle")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]

        public string PacienteDireccionCalle { get; set; }

        [Display(Name = "calle 2")]
        public string PacienteDireccionCalle2 { get; set; }

        [Required(ErrorMessage = "*Obligatorio")]
        [Display(Name = "Ciudad")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe de tener mas de 3 caracteres.")]
        public string PacienteCiudad { get; set; }

        [Required(ErrorMessage = "*Obligatorio")]
        [Display(Name = "Estado/Provincia")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe de tener mas de 3 caracteres.")]
        public string PacienteEstado_Provincia { get; set; }

        [Required(ErrorMessage = "*Obligatorio")]
        [Display(Name = "Codigo Postal")]
        [StringLength(25, ErrorMessage = "No debe tener mas de 25 caracteres.")]
        public string PacienteCodigoPostal { get; set; }

        [Required(ErrorMessage = "*Obligatorio ")]
        [Display(Name = "Codigo de area del telefono")]
        [StringLength(25, ErrorMessage = "No debe tener mas de 25 caracteres.")]
        public string PacienteNTelefonoCodigoArea { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "*Obligatorio")]
        [Display(Name = "Numero de Telefono")]

        public string PacienteNTelefono{ get; set; }

        [Display(Name = "Codigo de area del telefono")]

        public string PacienteNwasapcodigo { get; set; }

        [Display(Name = "Telefono de Whatsapp")]

        public string PacienteNwasap { get; set; }

    }
}
