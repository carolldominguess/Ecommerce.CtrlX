using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Ecommerce.CtrlX.Application.Interfaces;

namespace Ecommerce.CtrlX.Application.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        public T Add(T obj)
        {
            throw new NotImplementedException();
        }

        public void AddControl(T obj)
        {
            throw new NotImplementedException();
        }

        public T AddSaveChanges(T obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(int t, int s)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T obj)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T SearchFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Update(T obj)
        {
            throw new NotImplementedException();
        }

        public T UpdateSaveChanges(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
