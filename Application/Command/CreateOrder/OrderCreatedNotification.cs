using MediatR;
using MediatrWithPublish.Domain;

namespace MediatrWithPublish.Application.Command.CreateOrder;

public class OrderCreatedNotification : INotification
{
    public Order Order { get; set; }
}