using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.OrderAggregate;

namespace Core.Interfaces
{
    public interface IOrderService
    {
        Task<Order> CreateOrderAsync(string buyerEmail, int deliveryMethod, string basketId, Address shippingAddress);
        Task<IReadOnlyList<Order>> GetOrderForUserAsync(string buyerEmail);
        Task<Order> GetOrderByUdAsync(int id, string buyerEmail);
        Task<IReadOnlyList<DeliveryMethod>> GetDeliveryMethodsAsync();
    }
}