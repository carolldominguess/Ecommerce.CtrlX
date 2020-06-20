using Ecommerce.CtrlX.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.Interfaces
{
    public interface IProductsService : IDisposable
    {
        ProductsViewModel Add(ProductsViewModel products);
        ProductsViewModel GetProductsById(int id);
        Task<ProductsViewModel> GetProdutosByIdAsync(int id);
        IEnumerable<ProductsViewModel> GetAll();
        ProductsViewModel Update(ProductsViewModel products);
        void Remove(int id);
    }
}
