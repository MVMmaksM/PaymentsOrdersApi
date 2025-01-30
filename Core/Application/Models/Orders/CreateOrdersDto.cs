using Application.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Orders
{
    public class CreateOrdersDto
    {
        public List<int> ProductsIds { get; set; }
    }
}
