﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaDelivery.Domain.Models;
using PizzaDelivery.Domain.Models.Orders;
using PizzaDelivery.Domain.Models.Persons;

namespace PizzaDelivery.Services.Extensions
{
    public static class ClientExtensions
    {
        public static IEnumerable<Order> GetActiveOrders(this Client client)
        {
            return client.Orders
                .Where(x => x.OrderState != OrderState.Paid && x.OrderState != OrderState.Cancelled);
        }
    }
}
