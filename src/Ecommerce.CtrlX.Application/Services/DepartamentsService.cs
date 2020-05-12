using AutoMapper;
using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Application.Services
{
    public class DepartamentsService : IDepartamentsService
    {
        private readonly IDepartamentsRepository _departamentsRepository;

        public DepartamentsService(IDepartamentsRepository departamentsRepository)
        {
            _departamentsRepository = departamentsRepository;
        }

        public DepartamentsViewModel Add(DepartamentsViewModel departaments)
        {
            _departamentsRepository.Add(Mapper.Map<Departaments>(departaments));

            return departaments;
        }

        public IEnumerable<DepartamentsViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public DepartamentsViewModel GetDepartamentsById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public DepartamentsViewModel Update(DepartamentsViewModel departaments)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
