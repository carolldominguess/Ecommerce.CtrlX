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
    public class SalesDetailsService : ISalesDetailsService
    {
        private readonly ISalesDetailsRepository _salesDetailsRepository;

        public SalesDetailsService(ISalesDetailsRepository salesDetailsRepository)
        {
            _salesDetailsRepository = salesDetailsRepository;
        }

        public SalesDetailsViewModel Add(SalesDetailsViewModel salesDetails)
        {
            _salesDetailsRepository.Add(Mapper.Map<SalesDetails>(salesDetails));
            return salesDetails;
        }

        public SalesDetailsViewModel GetAll(SalesDetailsViewModel salesDetails)
        {
            return Mapper.Map<SalesDetailsViewModel>(_salesDetailsRepository.GetAll());
        }

        public IEnumerable<SalesDetailsViewModel> GetSalesDetailsById(int id)
        {
            return Mapper.Map<IEnumerable<SalesDetailsViewModel>>(_salesDetailsRepository.GetSalesDetailsById(id));
        }

        public SalesDetailsViewModel Update(SalesDetailsViewModel salesDetails)
        {
            var saleDetail = Mapper.Map<SalesDetails>(salesDetails);
            return Mapper.Map<SalesDetailsViewModel>(_salesDetailsRepository.Update(saleDetail));
        }

        public void Dispose()
        {
            _salesDetailsRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
