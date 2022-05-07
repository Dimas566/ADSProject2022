using ADSProject.Models;
using ADSProject.Repository;
using ADSProject.Utils;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ADSProject.Controllers
{
    public class CarreraController : Controller
    {
        private readonly ICarreraRepository carreraRepository;

        public CarreraController(ICarreraRepository carreraRepository)
        {
            this.carreraRepository = carreraRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = carreraRepository.obtenerCarreras();

                return View(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Form(int? idCarrera, Operaciones operaciones)
        {
            try
            {
                var carrera = new CarreraViewModel();

                if (idCarrera.HasValue)
                {
                    carrera = carreraRepository.obtenerCarreraPorId(idCarrera.Value);
                }

                // Se indica el tipo de operacion que se esta realizando
                ViewData["Operaciones"] = operaciones;


                return View(carrera); 
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Form(CarreraViewModel carreraViewModel)
        {
            try
            {
                if(carreraViewModel.idCarrera == 0) // para el caso de una insercion
                {
                    carreraRepository.agregarCarrera(carreraViewModel);
                } else
                {
                    carreraRepository.actualizarCarrera(carreraViewModel.idCarrera, carreraViewModel);
                }

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Delete(int idEstudiante)
        {
            try
            {
                carreraRepository.eliminarCarrera(0);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }
    }
}
