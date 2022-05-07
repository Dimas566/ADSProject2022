using ADSProject.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADSProject.Models
{
    public class CarreraViewModel
    {
        [Key]
        public int idCarrera { get; set; }

        [Display(Name = "Codigo")]
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(6, MinimumLength = 3, ErrorMessage = "La longitud del campo no deber menor de 3 caracteres ni mayor de 6 caracteres")]
        public string codigoCarrera { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "La longitud del campo no debe ser menor de 10 caracteres ni mayor de 50 caracteres")]
        public string nombreCarrera { get; set; }

        public bool estado { get; set; }
    }
}
