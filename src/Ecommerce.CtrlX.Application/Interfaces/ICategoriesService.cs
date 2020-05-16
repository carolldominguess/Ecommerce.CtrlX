using Ecommerce.CtrlX.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Application.Interfaces
{
    public interface ICategoriesService : IDisposable
    {
        CategoriesViewModel Add(CategoriesViewModel categories);
        CategoriesViewModel GetCategoriesById(int id);
        CategoriesViewModel GetById(int id);
        IEnumerable<CategoriesViewModel> GetAll();
        CategoriesViewModel Update(CategoriesViewModel categories);
        void Remove(int id);
    }
}
