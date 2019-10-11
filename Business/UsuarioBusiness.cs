using Business.Interface;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class UsuarioBusiness : IUsuarioBusiness
    {
        private readonly IUsuario _usuario;
        public UsuarioBusiness(IUsuario usuario)
        {
            _usuario = usuario;
        }
        public void Add(Usuario entity)
        {
             _usuario.Add(entity);
        }

        public IList<Usuario> GetEntities()
        {
            return _usuario.GetEntities();
        }

        public Usuario GetEntityById(int id)
        {
            return _usuario.GetEntityById(id);
        }

        public void Remove(Usuario usuario)
        {
            var usuarioDeletar = GetEntityById(usuario.IdUsuario);
            if(usuarioDeletar != null)
            {
                _usuario.Remove(usuario);
            }
        }

        public void Update(Usuario usuario)
        {
            _usuario.Update(usuario);
        }
        public int Save()
        {
            return _usuario.Save();
        }
    }
}
