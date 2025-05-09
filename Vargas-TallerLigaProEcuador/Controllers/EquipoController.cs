﻿using Microsoft.AspNetCore.Mvc;
using Vargas_TallerLigaProEcuador.Models;
using Vargas_TallerLigaProEcuador.Repositories;

namespace Vargas_TallerLigaProEcuador.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuelveListadoEquipos();

            return View(equipos);
        }
        public IActionResult Edit(int id)
        {
            EquipoRepository repository = new EquipoRepository();
            var equipo = repository.DevuelveInfoEquipo(id);
            return View(equipo);
        }
        /*Codigo Generado por ChatGPT*/
        [HttpPost]
        public IActionResult Edit(Equipo equipo)
        {
            EquipoRepository repository = new EquipoRepository();
            bool actualizado = repository.ActualizarEquipo(equipo);

            if (actualizado)
            {
                return RedirectToAction("ListaEquipos");
            }

            // Si no se pudo actualizar, se vuelve a mostrar la vista con el modelo original
            return View(equipo);
        }

    }
}
