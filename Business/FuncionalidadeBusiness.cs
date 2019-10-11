using Business.Interface;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class FuncionalidadeBusiness : IFuncionalidadeBusiness
    {
        private readonly IFuncionalidade _funcionalidade;

        public FuncionalidadeBusiness(IFuncionalidade funcionalidade)
        {
            _funcionalidade = funcionalidade;
        }
        public void Add(Funcionalidade funcionalidade)
        {
             _funcionalidade.Add(funcionalidade);
        }

        public IList<Funcionalidade> GetEntities()
        {
            return _funcionalidade.GetEntities();
        }

        public Funcionalidade GetEntityById(int id)
        {
            return _funcionalidade.GetEntityById(id);
        }

        public void Remove(Funcionalidade funcionalidade)
        {
             _funcionalidade.Remove(funcionalidade);
        }

        public void Update(Funcionalidade funcionalidade)
        {
            _funcionalidade.Update(funcionalidade);
        }

        public int Save()
        {
            return _funcionalidade.Save();
        }
    }
}
