﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreEfProcedures.Models;
using MvcCoreEfProcedures.Repositories;

namespace MvcCoreEfProcedures.Controllers
{
    public class EnfermosController : Controller
    {
        private RepositoryEnfermos repo;

        public EnfermosController(RepositoryEnfermos repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Enfermo> enfermos = this.repo.GetEnfermos();
            return View(enfermos);
        }

        public IActionResult Details(string inscripcion)
        {
            return View(this.repo.FindEnfermo(inscripcion));
        }

        public IActionResult Delete(string inscripcion)
        {
            this.repo.DeleteEnfermo(inscripcion);
            return RedirectToAction("Index");
        }
    }
}
