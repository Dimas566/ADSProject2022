using ADSProject.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ADSProject.Repository
{
    public class CarreraRepository : ICarreraRepository
    {
        private readonly List<CarreraViewModel> lstCarreraViewModel;

        public CarreraRepository()
        {
            lstCarreraViewModel = new List<CarreraViewModel>{
                new CarreraViewModel{ idCarrera = 1, nombreCarrera = "Ing. Sistemas", codigoCarrera = "I04" }
            };
        }
        public int agregarCarrera(CarreraViewModel carreraViewModel)
        {
            try
            {
                // Se evalua si la lista ya contiene al menos 1 elemento
                if(lstCarreraViewModel.Count > 0)
                {
                    carreraViewModel.idCarrera = lstCarreraViewModel.Last().idCarrera + 1;
                } else
                {
                    carreraViewModel.idCarrera = 1;
                }
                lstCarreraViewModel.Add(carreraViewModel);

                return carreraViewModel.idCarrera;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarCarrera(int idCarrera, CarreraViewModel carreraViewModel)
        {
            try
            {
                lstCarreraViewModel[lstCarreraViewModel.FindIndex(x => x.idCarrera == idCarrera)] = carreraViewModel;

                return carreraViewModel.idCarrera;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarCarrera(int idCarrera)
        {
            try
            {
                lstCarreraViewModel.RemoveAt(lstCarreraViewModel.FindIndex(x => x.idCarrera == idCarrera));

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CarreraViewModel obtenerCarreraPorId(int idCarrera)
        {
            try
            {
                var item = lstCarreraViewModel.Find(x => x.idCarrera == idCarrera);

                return item;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<CarreraViewModel> obtenerCarreras()
        {
            try
            {
                return lstCarreraViewModel;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
