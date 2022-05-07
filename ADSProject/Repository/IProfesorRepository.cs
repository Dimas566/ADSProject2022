using ADSProject.Models;
using System.Collections.Generic;

namespace ADSProject.Repository
{
    public interface IProfesorRepository
    {
        int agregarProfesor(ProfesorViewModel profesorViewModel);
        int actualizarProfesor(int idProfesor, ProfesorViewModel profesorViewModel);
        bool eliminarProfesor(int idProfesor);
        List<ProfesorViewModel> obtenerProfesores();
        ProfesorViewModel obtenerProfesorPorId(int idProfesor);
    }
}
