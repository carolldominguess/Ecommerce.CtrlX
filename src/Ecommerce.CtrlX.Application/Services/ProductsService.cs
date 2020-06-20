using AutoMapper;
using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public ProductsViewModel Add(ProductsViewModel products)
        {
            _productsRepository.Add(Mapper.Map<Products>(products));
            return products;
        }
        public IEnumerable<ProductsViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<ProductsViewModel>>(_productsRepository.GetAll());
        }

        public ProductsViewModel GetProductsById(int id)
        {
            return Mapper.Map<ProductsViewModel>(_productsRepository.GetProductsById(id));
        }

        public async Task<ProductsViewModel> GetProdutosByIdAsync(int id)
        {
            return Mapper.Map<ProductsViewModel>(await _productsRepository.GetProdutosByIdAsync(id));
        }
        public void Remove(int id)
        {
            _productsRepository.Remove(id);
        }

        public ProductsViewModel Update(ProductsViewModel products)
        {
            var prod = Mapper.Map<Products>(products);

            return Mapper.Map<ProductsViewModel>(_productsRepository.Update(prod));
        }
        public void Dispose()
        {
            _productsRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
