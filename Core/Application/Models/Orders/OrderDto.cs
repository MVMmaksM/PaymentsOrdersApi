using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Orders
{
    public class OrderDto
    {
        public List<ProductEntity> Products { get; set; }
        public decimal Price { get; set; }
    }
}
