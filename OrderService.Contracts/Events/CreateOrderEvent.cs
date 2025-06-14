using OrderService.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace OrderService.Contracts.Events
{
    public class OrderCreatedEvent
    {
        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public OrderMode Mode { get; set; }

        [Required]
        public List<OrderItemEvent> Items { get; set; } = new List<OrderItemEvent>();
    }

    public class OrderItemEvent
    {
        [Required]
        public Guid ProductId { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
