using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class OrderDto
    {
        // string buyerEmail, int deliveryMethodId, string basketId, Address shippingAddress
        public string BasketId { get; set; }
        public int DeliveryMethodId { get; set; }
        public AddressDto ShipToAddress { get; set; }
    }
}