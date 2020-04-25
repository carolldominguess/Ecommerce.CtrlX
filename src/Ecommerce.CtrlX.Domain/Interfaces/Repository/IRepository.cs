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
        Task<TEntity> AddSaveChangesAsync(TEntity obj);
        TEntity GetById(int id);
        Task<TEntity> GetByIdAsync(int id);
        TEntity GetByIdReadOnly(int id);
        Task<TEntity> GetByIdAsyncReadOnly(int? id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(int t, int s);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetAllAsync(int t, int s);
        TEntity Update(TEntity obj);
        TEntity UpdateSaveChanges(TEntity obj);
        Task<TEntity> UpdateSaveChangesAsync(TEntity obj);
        void Remove(int id);
        Task RemoveAsync(int id);
        void Remove(TEntity obj);
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate);
        TEntity SearchFirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SearchFirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
        Task<int> SaveChangesAsync();
        void AddControl(TEntity obj);
    }
}
