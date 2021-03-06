using ADSProject.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ADSProject.Repository
{
    public class ProfesorRepository : IProfesorRepository
    {
        private List<ProfesorViewModel> lstProfesores;

        public ProfesorRepository()
        {
            lstProfesores = new List<ProfesorViewModel>
            {
                new ProfesorViewModel{ idProfesor = 1, nombresProfesor = "Juan Antonio", apellidosProfesor = "Perez Garcia", 
                    correoProfesor = "Juan@usonsonate.edu.sv"}
            };
        }
        public int agregarProfesor(ProfesorViewModel profesorViewModel)
        {
            try
            {
                if(lstProfesores.Count > 0)
                {
                    profesorViewModel.idProfesor = lstProfesores.Last().idProfesor + 1;
                } else
                {
                    profesorViewModel.idProfesor = 1;
                }
                lstProfesores.Add(profesorViewModel);

                return profesorViewModel.idProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarProfesor(int idProfesor, ProfesorViewModel profesorViewModel)
        {
            try
            {
                lstProfesores[lstProfesores.FindIndex(x => x.idProfesor == idProfesor)] = profesorViewModel;

                return profesorViewModel.idProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarProfesor(int idProfesor)
        {
            try
            {
                lstProfesores.RemoveAt(lstProfesores.FindIndex(x => x.idProfesor == idProfesor));

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ProfesorViewModel obtenerProfesorPorId(int idProfesor)
        {
            try
            {
                var item = lstProfesores.Find(x => x.idProfesor == idProfesor);

                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProfesorViewModel> obtenerProfesores()
        {
            try
            {
                return lstProfesores;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
