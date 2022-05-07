using ADSProject.Models;
using System.Collections.Generic;

namespace ADSProject.Repository
{
    public interface ICarreraRepository
    {
        List<CarreraViewModel> obtenerCarreras();

        int agregarCarrera(CarreraViewModel carreraViewModel);

        int actualizarCarrera(int idCarrera, CarreraViewModel carreraViewModel);

        bool eliminarCarrera(int idCarrera);

        CarreraViewModel obtenerCarreraPorId(int idCarrera);

    }
}
