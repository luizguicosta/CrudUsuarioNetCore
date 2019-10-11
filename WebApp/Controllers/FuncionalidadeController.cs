﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class FuncionalidadeController : Controller
    {
        private readonly IFuncionalidadeBusiness _funcionalidadeBusiness;
        public FuncionalidadeController(IFuncionalidadeBusiness funcionalidadeBusiness)
        {
            _funcionalidadeBusiness = funcionalidadeBusiness;
        }

        /// <summary>
        /// Lista de funcionalidades
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Index()
        {
            return View(_funcionalidadeBusiness.GetEntities());
        }

        /// <summary>
        /// Detalhes da funcionalidade
        /// </summary>
        /// <param name="id">Id da funcionalidade</param>
        /// <returns>View</returns>
        public ActionResult Details(int id)
        {
            return View(_funcionalidadeBusiness.GetEntityById(id));
        }

        /// <summary>
        /// Crear Funcionalidade(GET)
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Create()
        {
            return View(new Funcionalidade());
        }

        /// <summary>
        /// Crear Funcionalidade(Post)
        /// </summary>
        /// <param name="collection">Funcionalidade</param>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Funcionalidade funcionalidade)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(funcionalidade);
                }
                _funcionalidadeBusiness.Add(funcionalidade);
                TempData["Message"] = "Funcionalidade Salva com sucesso";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["MessageError"] = "Erro ao salvar a Funcionalidade";
                return View(funcionalidade);
            }
        }

        /// <summary>
        /// Editar funcionalidade GET
        /// </summary>
        /// <param name="id">Id funcionalidade</param>
        /// <returns>View</returns>
        public ActionResult Edit(int id)
        {
            var funcionalidade = _funcionalidadeBusiness.GetEntityById(id);
            if(funcionalidade != null)
            {
                return View(funcionalidade);
            }
            return View();
        }

        /// <summary>
        /// Editar funcionalidade Post
        /// </summary>
        /// <param name="id">Id funcionalidade</param>
        /// <param name="funcionalidade">Funcionalidade</param>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Funcionalidade funcionalidade)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(funcionalidade);
                }
                _funcionalidadeBusiness.Update(funcionalidade);
                _funcionalidadeBusiness.Save();
                TempData["Message"] = "Funcionalidade Editada com sucesso";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["MessageError"] = "Erro ao Editar a Funcionalidade";
                return View();
            }
        }

        /// <summary>
        /// Deletar funcionalidade GET
        /// </summary>
        /// <param name="id">Id Funcionalidade</param>
        /// <returns>View</returns>
        public ActionResult Delete(int id)
        {
            try
            {
                var funcionalidade = _funcionalidadeBusiness.GetEntityById(id);
                if (funcionalidade != null)
                {
                    _funcionalidadeBusiness.Remove(funcionalidade);
                    TempData["Message"] = "Funcionalidade Salva com sucesso";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception)
            {
                TempData["MessageError"] = "Erro ao deletar a Funcionalidade";
            }
            
            return View();
        }
    }
}