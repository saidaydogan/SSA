﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SSA.Data.Core.BaseRepo
{
    public interface IBaseRepository<T> where T : EntityObject
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        int Count(Expression<Func<T, bool>> where);

        T Get(Expression<Func<T, bool>> where);
        T GetById(long id);
        T GetById(string id);
        Task<T> GetAsync(Expression<Func<T, bool>> where);

        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        Task<List<T>> GetManyAsync(Expression<Func<T, bool>> where);
        IQueryable<T> GetQueryable(Expression<Func<T, bool>> where);
        //IQueryable<TResult> GetQueryable<TResult>(Expression<Func<T, bool>> where, Expression<Func<T, TResult>> select);
        void Save();
    } 
}