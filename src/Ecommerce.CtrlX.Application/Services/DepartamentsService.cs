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
            return Mapper.Map<IEnumerable<DepartamentsViewModel>>(_departamentsRepository.GetAll());
        }

        public DepartamentsViewModel GetDepartamentsById(int id)
        {
            return Mapper.Map<DepartamentsViewModel>(_departamentsRepository.GetDepartamentsById(id));
        }

        public void Remove(int id)
        {
            _departamentsRepository.Remove(id);
        }

        public DepartamentsViewModel Update(DepartamentsViewModel departaments)
        {
            var dep = Mapper.Map<Departaments>(departaments);

            return Mapper.Map<DepartamentsViewModel>(_departamentsRepository.Update(dep));
        }
        public void Dispose()
        {
            _departamentsRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
