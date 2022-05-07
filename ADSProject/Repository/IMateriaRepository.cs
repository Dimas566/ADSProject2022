using ADSProject.Models;
using System.Collections.Generic;

namespace ADSProject.Repository
{
    public interface IMateriaRepository
    {
        int agregarMateria(MateriaViewModel materiaViewModel);
        int actualizarMateria(int idMateria, MateriaViewModel materiaViewModel);
        bool eliminarMateria(int idMateria);
        MateriaViewModel obtenerMateriaPorId(int idMateria);
        List<MateriaViewModel> obtenerMaterias();

    }
}
