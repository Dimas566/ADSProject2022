using ADSProject.Models;
using ADSProject.Repository;
using ADSProject.Utils;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ADSProject.Controllers
{
    public class MateriaController : Controller
    {
        private readonly IMateriaRepository materiaRepository;

        public MateriaController(IMateriaRepository materiaRepository)
        {
            this.materiaRepository = materiaRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = materiaRepository.obtenerMaterias();

                return View(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Form(int? idMateria, Operaciones operaciones)
        {
            try
            {
                var materia = new MateriaViewModel();

                if (idMateria.HasValue)
                {
                    materia = materiaRepository.obtenerMateriaPorId(idMateria.Value);
                }

                ViewData["Operaciones"] = operaciones;

                return View(materia);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Form(MateriaViewModel materiaViewModel)
        {
            try
            {
                if(materiaViewModel.idMateria == 0)
                {
                    materiaRepository.agregarMateria(materiaViewModel);
                } else
                {
                    materiaRepository.actualizarMateria(materiaViewModel.idMateria, materiaViewModel);
                }

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Delete(int idMateria)
        {
            try
            {
                materiaRepository.eliminarMateria(idMateria);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
