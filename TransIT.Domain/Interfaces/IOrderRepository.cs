﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransIT.Domain.Models;

namespace TransIT.Domain.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> CreateOrderWithPackages(Order order);
        
    }
}