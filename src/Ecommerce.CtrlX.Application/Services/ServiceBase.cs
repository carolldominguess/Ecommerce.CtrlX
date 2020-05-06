using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;

namespace Ecommerce.CtrlX.Application.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public ServiceBase(IRepository<T> repository)
        {
            _repository = repository;
        }

        public T Add(T obj)
        {
            return _repository.Add(obj);
        }

        public void AddControl(T obj)
        {
            throw new NotImplementedException();
        }

        public T AddSaveChanges(T obj)
        {
            return _repository.AddSaveChanges(obj);
        }
        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<T> GetAll(int t, int s)
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Remove(T obj)
        {
            _repository.Remove(obj);
        }

        public int SaveChanges()
        {
            return _repository.SaveChanges();
        }

        public IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            return _repository.Search(predicate);
        }

        public T SearchFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Update(T obj)
        {
            return _repository.Update(obj);
        }

        public T UpdateSaveChanges(T obj)
        {
            return _repository.UpdateSaveChanges(obj);
        }
        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
