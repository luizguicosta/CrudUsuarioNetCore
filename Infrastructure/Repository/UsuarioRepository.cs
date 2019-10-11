using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Repository.Base;
using Infrastructure.Repository.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuario
    {
        public UsuarioRepository(DataBaseContext context) : base(context) { }
    }
}
