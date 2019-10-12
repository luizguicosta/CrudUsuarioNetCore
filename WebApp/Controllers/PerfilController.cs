using System;
using System.Collections.Generic;
using System.Linq;
using Business.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApp.Controllers
{
    public class PerfilController : Controller
    {
        private readonly IPerfilBusiness _perfilBusiness;
        private readonly IFuncionalidadeBusiness _funcionalidadeBusiness;
        public PerfilController(IPerfilBusiness perfilBusiness, IFuncionalidadeBusiness funcionalidadeBusiness)
        {
            _perfilBusiness = perfilBusiness;
            _funcionalidadeBusiness = funcionalidadeBusiness;
        }

        /// <summary>
        /// Listar Perfis
        /// </summary>
        /// <returns>lista de perfis</returns>
        public ActionResult Index()
        {
            return View(_perfilBusiness.GetEntities());
        }

        /// <summary>
        /// Detalhes do perfil
        /// </summary>
        /// <param name="id">Id do perfil</param>
        /// <returns>Perfil</returns>
        public ActionResult Details(int id)
        {
            var perfil = _perfilBusiness.GetEntityById(id);
            if (perfil != null)
            {
                return View(perfil);
            }
            return View();
        }

        /// <summary>
        /// Criar um novo perfil(GET)
        /// </summary>
        /// <returns>novo perfil</returns>
        public ActionResult Create()
        {
            ViewBag.Funcionalidade = _funcionalidadeBusiness.GetEntities();
            return View(new Perfil());
        }

        /// <summary>
        /// Criar novo perfil (Post)
        /// </summary>
        /// <param name="perfil">O perfil a ser persistido</param>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string perfil, string funcionalidades)
        {
            var newPerfil = JsonConvert.DeserializeObject<Perfil>(perfil);
            var listaFunc = JsonConvert.DeserializeObject<List<Funcionalidade>>(funcionalidades);
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(perfil);
                }
                _perfilBusiness.Add(newPerfil);
                TempData["Message"] = "Perfil Salvo com sucesso";
                UpdateFuncionalidades(newPerfil, listaFunc);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                TempData["MessageError"] = "Erro ao Salvar o perfil";
                return View(newPerfil);
            }
        }

        /// <summary>
        /// Editar perfil(GET)
        /// </summary>
        /// <param name="id">id do perfil</param>
        /// <returns>View com perfil</returns>
        public ActionResult Edit(int id)
        {
            ViewBag.Funcionalidade = _funcionalidadeBusiness.GetEntities().Where(x => x.IdPerfil != id);
            var perfil = _perfilBusiness.GetEntityById(id);
            if (perfil != null)
            {
                View(perfil);
            }
            return View();
        }

        /// <summary>
        /// Editar perfil(Post)
        /// </summary>
        /// <param name="id">id do perfil</param>
        /// <param name="collection">Perfil</param>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Perfil perfil)
        {
            try
            {
                _perfilBusiness.Update(perfil);
                _perfilBusiness.Save();
                TempData["Message"] = "Perfil Editado com sucesso";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["MessageError"] = "Erro ao Editar o perfil";
                return View(perfil);
            }
        }

        /// <summary>
        /// Deletar perfil(get)
        /// </summary>
        /// <param name="id">Id do perfil</param>
        /// <returns>View</returns>
        public ActionResult Delete(int id)
        {
            try
            {
                var perfil = _perfilBusiness.GetEntityById(id);
                if (perfil != null)
                {
                    RemovePerfilFuncionalidade(perfil.Funcionalidades);
                    perfil.Funcionalidades.Clear();
                    _perfilBusiness.Remove(perfil);
                    TempData["Message"] = "Perfil Deletado com sucesso";
                }

            }
            catch (Exception ex)
            {
                TempData["MessageError"] = "Erro ao deletar o perfil";
            }

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// update relacionamento entre perfil e funcionalidade
        /// </summary>
        /// <param name="perfil"></param>
        /// <param name="funcionalidades"></param>
        private void UpdateFuncionalidades(Perfil perfil, List<Funcionalidade> funcionalidades)
        {
            if (funcionalidades.Count() > 0)
            {
                foreach (var item in funcionalidades)
                {
                    var func = _funcionalidadeBusiness.GetEntityById(item.IdFuncionalidade);
                    func.IdPerfil = perfil.IdPerfil;
                    _funcionalidadeBusiness.Update(func);
                }

                _funcionalidadeBusiness.Save();
            }
        }

        /// <summary>
        /// Remover o idperfil da funcionalidade
        /// </summary>
        /// <param name="funcionalidades">Lista de funcionalidades</param>
        private void RemovePerfilFuncionalidade(List<Funcionalidade> funcionalidades)
        {
            if(funcionalidades.Count > 0)
            {
                foreach (var item in funcionalidades)
                {
                    var func = _funcionalidadeBusiness.GetEntityById(item.IdFuncionalidade);
                    func.Perfil = null;
                    _funcionalidadeBusiness.Update(func);
                }
                _funcionalidadeBusiness.Save();
            }
        }
    }
}