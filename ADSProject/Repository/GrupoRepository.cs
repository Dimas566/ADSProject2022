using ADSProject.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ADSProject.Repository
{
    public class GrupoRepository : IGrupoRepository
    {
        private readonly List<GrupoViewModel> lstGrupos;


        public GrupoRepository()
        {
            lstGrupos = new List<GrupoViewModel>();
        }

        public int agregarGrupo(GrupoViewModel grupoViewModel)
        {
            try
            {
                if(lstGrupos.Count > 0)
                {
                    grupoViewModel.idGrupo = lstGrupos.Last().idGrupo + 1;
                } else
                {
                    grupoViewModel.idGrupo = 1;
                }

                lstGrupos.Add(grupoViewModel);

                return grupoViewModel.idGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarGrupo(int idGrupo, GrupoViewModel grupoViewModel)
        {
            try
            {
                lstGrupos[lstGrupos.FindIndex(x => x.idGrupo == idGrupo)] = grupoViewModel;

                return grupoViewModel.idGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool deleteGrupo(int idGrupo)
        {
            try
            {
                lstGrupos.RemoveAt(lstGrupos.FindIndex(x => x.idGrupo == idGrupo));

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public GrupoViewModel obtenerGrupoPorId(int idGrupo)
        {
            try
            {
                var item = lstGrupos.Find(x => x.idGrupo == idGrupo);

                return item; 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<GrupoViewModel> obtenerGrupos()
        {
            try
            {
                return lstGrupos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
