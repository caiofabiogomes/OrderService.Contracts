using OrderService.Contracts.Enums;

namespace OrderService.Contracts.Events
{
    public class UpdateProductEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ProductTypeEnum ProductType { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public AvailabilityStatusEnum Availability { get; set; }
    }
}

