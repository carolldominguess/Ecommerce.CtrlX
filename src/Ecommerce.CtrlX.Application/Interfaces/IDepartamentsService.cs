using Ecommerce.CtrlX.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Application.Interfaces
{
    public interface IDepartamentsService : IDisposable
    {
        DepartamentsViewModel Add(DepartamentsViewModel departaments);
        DepartamentsViewModel GetDepartamentsById(int id);
        IEnumerable<DepartamentsViewModel> GetAll();
        DepartamentsViewModel Update(DepartamentsViewModel departaments);
        void Remove(int id);
    }
}
