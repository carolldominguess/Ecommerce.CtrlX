using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity AddSaveChanges(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(int t, int s);
        TEntity Update(TEntity obj);
        TEntity UpdateSaveChanges(TEntity obj);
        void Remove(int id);
        void Remove(TEntity obj);
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
        TEntity SearchFirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
        void AddControl(TEntity obj);
    }
}
