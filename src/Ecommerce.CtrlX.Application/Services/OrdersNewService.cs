using AutoMapper;
using Ecommerce.CtrlX.Application.Interfaces;
using Ecommerce.CtrlX.Application.ViewModels;
using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.Services
{
    public class OrdersNewService : IOrdersNewService
    {
        private readonly IOrdersNewRepository _ordersNewRepository;

        public OrdersNewService(IOrdersNewRepository ordersNewRepository)
        {
            _ordersNewRepository = ordersNewRepository;
        }

        public OrdersNewViewModel Add(OrdersNewViewModel orders)
        {
            _ordersNewRepository.Add(Mapper.Map<OrdersNew>(orders));
            return orders;
        }        

        public OrdersNewViewModel GetOrderById(int id)
        {
            return Mapper.Map<OrdersNewViewModel>(_ordersNewRepository.GetOrderById(id));
        }

        public async Task<OrdersNewViewModel> GetOrdersByIdAsync(int id)
        {
            return Mapper.Map<OrdersNewViewModel>(await _ordersNewRepository.GetOrdersByIdAsync(id));
        }

        public IEnumerable<OrdersNewViewModel> ObterPedidos()
        {
            return Mapper.Map<IEnumerable<OrdersNewViewModel>>(_ordersNewRepository.ObterPedidos());
        }
        public IEnumerable<OrdersNewViewModel> ObterPedidosByUser(string user)
        {
            return Mapper.Map<IEnumerable<OrdersNewViewModel>>(_ordersNewRepository.ObterPedidosByUser(user));
        }
        public OrdersNewViewModel Update(OrdersNewViewModel orders)
        {
            var order = Mapper.Map<OrdersNew>(orders);
            return Mapper.Map<OrdersNewViewModel>(_ordersNewRepository.Update(order));
        }
        public void Dispose()
        {
            _ordersNewRepository.Dispose();
        }        
    }
}
