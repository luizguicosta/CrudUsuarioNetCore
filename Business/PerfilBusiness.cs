using Business.Interface;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class PerfilBusiness : IPerfilBusiness
    {
        private readonly IPerfil _perfil;

        public PerfilBusiness(IPerfil perfil)
        {
            _perfil = perfil;
        }

        public void Add(Perfil perfil)
        {
            if (perfil.Funcionalidades.Count > 0)
                perfil.Funcionalidades.Clear();
            _perfil.Add(perfil);
        }

        public IList<Perfil> GetEntities()
        {
            return _perfil.GetEntities();
        }

        public Perfil GetEntityById(int id)
        {
            return _perfil.GetEntityById(id);
        }

        public void Remove(Perfil perfil)
        {
            _perfil.Remove(perfil);
        }

        public void Update(Perfil perfil)
        {
            _perfil.Update(perfil);
        }
        public int Save()
        {
            return _perfil.Save();
        }
    }
}
