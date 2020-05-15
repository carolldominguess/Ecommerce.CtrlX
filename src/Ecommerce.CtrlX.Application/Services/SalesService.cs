using AutoMapper;
using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.Services
{
    public class SalesService : ISalesService
    {
        private readonly ISalesRepository _salesRepository;

        public SalesService(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }

        public SalesViewModel Add(SalesViewModel sales)
        {
            _salesRepository.Add(Mapper.Map<Sales>(sales));
            return sales;
        }

        public IEnumerable<SalesViewModel> ObterVendas()
        {
            return Mapper.Map<IEnumerable<SalesViewModel>>(_salesRepository.ObterVendas());
        }

        public SalesViewModel GetSalesById(int id)
        {
            return Mapper.Map<SalesViewModel>(_salesRepository.GetSalesById(id));
        }

        public SalesViewModel Update(SalesViewModel sales)
        {
            var sale = Mapper.Map<Sales>(sales);

            return Mapper.Map<SalesViewModel>(_salesRepository.Update(sale));
        }

        public void Dispose()
        {
            _salesRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
