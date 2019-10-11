﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
    public interface IBaseInterface<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        TEntity GetEntityById(int id);
        IList<TEntity> GetEntities();
        void Remove(TEntity entity);
        int Save();
    }
}
