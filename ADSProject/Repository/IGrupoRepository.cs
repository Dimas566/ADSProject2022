using ADSProject.Models;
using System.Collections.Generic;

namespace ADSProject.Repository
{
    public interface IGrupoRepository
    {
        int agregarGrupo(GrupoViewModel grupoViewModel);
        int actualizarGrupo(int idGrupo, GrupoViewModel grupoViewModel);
        bool deleteGrupo(int idGrupo);
        List<GrupoViewModel> obtenerGrupos();
        GrupoViewModel obtenerGrupoPorId(int idGrupo);
    }
}
