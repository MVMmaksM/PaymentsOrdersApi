using Application.Models.Products;
using System.Text.Json.Serialization;

namespace Application.Models.Orders
{
    public class OrderDto
    {
        [JsonPropertyOrder(1)]
        public long Id { get; set; }


        [JsonPropertyOrder(2)]
        public DateTime CreateAt { get; set; }


        [JsonPropertyOrder(3)]
        public decimal TotalCost { get; set; }


        [JsonPropertyOrder(4)]
        public List<ProductsDto> Products { get; set; }
    }
}
