using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public long CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
       
        public List<ManufacturerEntity> Manufacturers { get; set; }
  
        public List<SellerEntity> Sellers { get; set; }

        public List<OrdersEntity> Orders { get; set; }
    }
}
