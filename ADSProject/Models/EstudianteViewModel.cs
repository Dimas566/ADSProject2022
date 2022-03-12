using ADSProject.Utils;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class EstudianteViewModel
    {
        public int idEstudiante { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50,MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 3 caracteres.")]
        public string nombresEstudiante { get; set; }

        public string apellidosEstudiante { get; set; }

        public string codigoEstudiante { get; set; }

        public string correoEstudiante { get; set; }
    }
}
