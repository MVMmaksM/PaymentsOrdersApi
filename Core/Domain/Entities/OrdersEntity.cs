using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrdersEntity : BaseEntity
    {
        public List<ProductEntity> Products { get; set; }
        public decimal Price { get; set; }
    }
}
