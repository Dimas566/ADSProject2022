using ADSProject.Utils;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class GrupoViewModel
    {
        [Display(Name = "ID")]
        [Key]
        public int idGrupo { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Carrera")]
        public int idCarrera { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Materia")]
        public int idMateria { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Profesor")]
        public int idProfesor { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Ciclo")]
        public int ciclo { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Anio")]
        public int anio { get; set; }

        public bool estado { get; set; }
    }
}
