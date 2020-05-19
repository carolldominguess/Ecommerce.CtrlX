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
    public class OrdersDetailsService : IOrdersDetailsService
    {
        private readonly IOrdersDetailsRepository _ordersDetailsRepository;

        public OrdersDetailsService(IOrdersDetailsRepository ordersDetailsRepository)
        {
            _ordersDetailsRepository = ordersDetailsRepository;
        }

        public OrdersDetailsViewModel Add(OrdersDetailsViewModel ordersDetails)
        {
            _ordersDetailsRepository.Add(Mapper.Map<OrdersDetails>(ordersDetails));
            return ordersDetails;
        }

        public OrdersDetailsViewModel GetAll(OrdersDetailsViewModel ordersDetails)
        {
            return Mapper.Map<OrdersDetailsViewModel>(_ordersDetailsRepository.GetAll());
        }

        public OrdersDetailsViewModel Update(OrdersDetailsViewModel ordersDetails)
        {
            var orderDetail = Mapper.Map<OrdersDetails>(ordersDetails);
            return Mapper.Map<OrdersDetailsViewModel>(_ordersDetailsRepository.Update(orderDetail));
        }

        public IEnumerable<OrdersDetailsViewModel> GetOrdersDetailsById(int id)
        {
            return Mapper.Map<IEnumerable<OrdersDetailsViewModel>>(_ordersDetailsRepository.GetOrdersDetailsById(id));
        }

        public void Dispose()
        {
            _ordersDetailsRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
