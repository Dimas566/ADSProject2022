using ADSProject.Utils;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class MateriaViewModel
    {
        [Display(Name = "ID")]
        [Key]
        public int idMateria { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Materia")]
        [StringLength(25, MinimumLength = 10, ErrorMessage = "La longitud del campo no debe ser menor de 10 caracteres ni mayor de 25 caracteres")]
        public string nombreMateria { get; set; }

        public bool estado { get; set; }
    }
}
