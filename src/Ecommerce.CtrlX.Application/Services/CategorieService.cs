using AutoMapper;
using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Application.Services
{
    public class CategorieService : ICategoriesService
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategorieService(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public CategoriesViewModel Add(CategoriesViewModel categories)
        {
            _categoriesRepository.Add(Mapper.Map<Categories>(categories));
            return categories;
        }     

        public IEnumerable<CategoriesViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<CategoriesViewModel>>(_categoriesRepository.GetAll());
        }

        public CategoriesViewModel GetById(int id)
        {
            return Mapper.Map<CategoriesViewModel>(_categoriesRepository.GetById(id));
        }

        public CategoriesViewModel GetCategoriesById(int id)
        {
            return Mapper.Map<CategoriesViewModel>(_categoriesRepository.GetCategoriesById(id));
        }

        public void Remove(int id)
        {
            _categoriesRepository.Remove(id);
        }

        public CategoriesViewModel Update(CategoriesViewModel categories)
        {
            var cat = Mapper.Map<Categories>(categories);

            return Mapper.Map<CategoriesViewModel>(_categoriesRepository.Update(cat));
        }
        public void Dispose()
        {
            _categoriesRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
