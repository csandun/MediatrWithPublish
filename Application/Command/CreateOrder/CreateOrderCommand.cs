using MediatR;
using MediatrWithPublish.Domain;

namespace MediatrWithPublish.Application.Command.CreateOrder;

public class CreateOrderCommand :  IRequest<Order>
{
    public string CustomerName { get; set; }
    public decimal TotalAmount { get; set; }
    public string CustomerEmail { get; set; }
}