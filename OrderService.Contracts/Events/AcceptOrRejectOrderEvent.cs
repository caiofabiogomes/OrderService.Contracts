using OrderService.Contracts.Enums;

namespace OrderService.Contracts.Events
{
    public class AcceptOrRejectOrderEvent
    {
        public Guid OrderId { get; set; }

        public AcceptOrRejectOrderEnum Status { get; set; }
    }
}
