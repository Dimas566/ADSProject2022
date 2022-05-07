using ADSProject.Utils;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class ProfesorViewModel
    {
        [Display(Name = "ID")]
        [Key]
        public int idProfesor { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50,MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser menor de 3 caracteres ni mayor de 50 caracteres")]
        public string nombresProfesor { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser menor de 3 caracteres ni mayor de 50 caracteres")]
        public string apellidosProfesor { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "La longitud del campo no debe ser menor de 10 caracteres ni mayor de 50 caracteres")]
        public string correoProfesor { get; set; }

        public bool estado { get; set; }
    }
}
