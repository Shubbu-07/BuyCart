using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class Order
    {
        public int? Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? Total { get; set; }
        public string? Status { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
