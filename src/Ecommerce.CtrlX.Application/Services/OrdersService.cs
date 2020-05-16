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
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrdersService(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public OrdersViewModel Add(OrdersViewModel orders)
        {
            _ordersRepository.Add(Mapper.Map<Orders>(orders));
            return orders;
        }

        public OrdersViewModel GetOrderById(int id)
        {
            return Mapper.Map<OrdersViewModel>(_ordersRepository.GetOrderById(id));
        }

        public IEnumerable<OrdersViewModel> ObterPedidos()
        {
            return Mapper.Map<IEnumerable<OrdersViewModel>>(_ordersRepository.ObterPedidos());
        }

        public OrdersViewModel update(OrdersViewModel orders)
        {
            var order = Mapper.Map<Orders>(orders);
            return Mapper.Map<OrdersViewModel>(_ordersRepository.Update(order));
        }
        public void Dispose()
        {
            _ordersRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
