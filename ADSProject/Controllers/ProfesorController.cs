using ADSProject.Models;
using ADSProject.Repository;
using ADSProject.Utils;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ADSProject.Controllers
{
    public class ProfesorController : Controller
    {
        private readonly IProfesorRepository profesorRepository;

        public ProfesorController(IProfesorRepository profesorRepository)
        {
            this.profesorRepository = profesorRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = profesorRepository.obtenerProfesores();

                return View(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Form(int? idProfesor, Operaciones operaciones)
        {
            try
            {
                var profesor = new ProfesorViewModel();

                if (idProfesor.HasValue)
                {
                    profesor = profesorRepository.obtenerProfesorPorId(idProfesor.Value);
                }

                ViewData["Operaciones"] = operaciones;

                return View(profesor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Form(ProfesorViewModel profesorViewModel)
        {
            try
            {
                if(profesorViewModel.idProfesor == 0) // Caso agregar
                {
                    profesorRepository.agregarProfesor(profesorViewModel);
                } else
                {
                    profesorRepository.actualizarProfesor(profesorViewModel.idProfesor, profesorViewModel);
                }

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Delete(int idProfesor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    profesorRepository.eliminarProfesor(idProfesor);
                }

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
