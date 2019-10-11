using Domain.Interfaces.Base;
using Infrastructure.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseInterface<TEntity>, IDisposable where TEntity : class
    {

        private readonly DataBaseContext _context;
        public BaseRepository(DataBaseContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IList<TEntity> GetEntities()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetEntityById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }

        public int Save()
        {
           return  _context.SaveChanges();
        }
    }
}
