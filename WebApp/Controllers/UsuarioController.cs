using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioBusiness _usuarioBusiness;
        private readonly IPerfilBusiness _perfilBusiness;
        public UsuarioController(IUsuarioBusiness usuarioBusiness, IPerfilBusiness perfilBusiness)
        {
            _usuarioBusiness = usuarioBusiness;
            _perfilBusiness = perfilBusiness;
        }
        
        /// <summary>
        /// Listar usuarios
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        public ActionResult Index()
        {
            var usuarios = _usuarioBusiness.GetEntities();
            return View(usuarios);
        }

        /// <summary>
        /// Detalhes do usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns>View</returns>
        public ActionResult Details(int id)
        {
            var usuario = _usuarioBusiness.GetEntityById(id);
            if(usuario != null)
            {
                return View(usuario);
            }
            return View();
        }

        /// <summary>
        /// Criar usuario(GET)
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Create()
        {
            ViewBag.Perfis = _perfilBusiness.GetEntities();
            return View(new Usuario());
        }

        /// <summary>
        /// Criar usuario(Post)
        /// </summary>
        /// <param name="usuario">usuario</param>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario)
        {
            try
            {
               _usuarioBusiness.Add(usuario);
                TempData["Message"] = "Usuario Salvo com sucesso";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["MessageError"] = "Erro ao Salvar o Usuario";
                return View(usuario);
            }
        }

        /// <summary>
        /// Editar usuario(GET)
        /// </summary>
        /// <param name="id">Id do usuario</param>
        /// <returns>View</returns>
        public ActionResult Edit(int id)
        {
            ViewBag.Perfis = _perfilBusiness.GetEntities();
            var usuario = _usuarioBusiness.GetEntityById(id);
            if(usuario != null)
            {
                return View(usuario);
            }
            return View();
        }

        /// <summary>
        /// Editar usuario(Post)
        /// </summary>
        /// <param name="id">id do usuario</param>
        /// <param name="usuario">Usuario</param>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Usuario usuario)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(usuario);
                }
                _usuarioBusiness.Update(usuario);
                _usuarioBusiness.Save();
                TempData["Message"] = "Usuario Editado com sucesso";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["MessageError"] = "Erro ao Editar o Usuario";
                return View();
            }
        }

        /// <summary>
        /// Deletar usuario(Get)
        /// </summary>
        /// <param name="id">Id do usuario</param>
        /// <returns>View</returns>
        public ActionResult Delete(int id)
        {
            try
            {
                var usuario = _usuarioBusiness.GetEntityById(id);
                if (usuario != null)
                {
                    _usuarioBusiness.Remove(usuario);
                    TempData["Message"] = "Usuario deletado com sucesso";
                }
            }
            catch (Exception)
            {
                TempData["MessageError"] = "Erro ao Deletar o Usuario";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}