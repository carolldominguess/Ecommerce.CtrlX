using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.Interfaces
{
    public interface IServiceBase<T> : IDisposable where T : class
    {
        T Add(T obj);
        T AddSaveChanges(T obj);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(int t, int s);
        T Update(T obj);
        T UpdateSaveChanges(T obj);
        void Remove(int id);
        void Remove(T obj);
        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);
        T SearchFirstOrDefault(Expression<Func<T, bool>> predicate);
        int SaveChanges();
        void AddControl(T obj);
    }
}
