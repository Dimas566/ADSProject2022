using ADSProject.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ADSProject.Repository
{
    public class MateriaRepository : IMateriaRepository
    {
        private readonly List<MateriaViewModel> lstMaterias;

        public MateriaRepository()
        {
            lstMaterias = new List<MateriaViewModel>
            {
                new MateriaViewModel{ idMateria = 1, nombreMateria = "Matematicas" }
            };
        }
        public int agregarMateria(MateriaViewModel materiaViewModel)
        {
            try
            {
                // Se evalua que la lista contenga al menos 1 elemento
                if(lstMaterias.Count > 0)
                {
                    materiaViewModel.idMateria = lstMaterias.Last().idMateria + 1;
                } else
                {
                    materiaViewModel.idMateria = 1;
                }

                lstMaterias.Add(materiaViewModel);

                return materiaViewModel.idMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int actualizarMateria(int idMateria, MateriaViewModel materiaViewModel)
        {
            try
            {
                lstMaterias[lstMaterias.FindIndex(x => x.idMateria == idMateria)] = materiaViewModel;

                return materiaViewModel.idMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarMateria(int idMateria)
        {
            try
            {
                lstMaterias.RemoveAt(lstMaterias.FindIndex(x => x.idMateria == idMateria));

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public MateriaViewModel obtenerMateriaPorId(int idMateria)
        {
            try
            {
                var item = lstMaterias.Find(x => x.idMateria == idMateria);

                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MateriaViewModel> obtenerMaterias()
        {
            try
            {
                return lstMaterias;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
