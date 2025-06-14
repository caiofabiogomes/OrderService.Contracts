using System.ComponentModel.DataAnnotations;

namespace OrderService.Contracts.Events
{
    public class CancelOrderEvent
    {
        [Required]
        public Guid OrderId { get; set; }

        [Required]
        public string Justification { get; set; }
    }
}
