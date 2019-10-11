using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Repository.Base;
using Infrastructure.Repository.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class PerfilRepository : BaseRepository<Perfil>, IPerfil
    {
        public PerfilRepository(DataBaseContext context) : base(context) { }
    }
}
