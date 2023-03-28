using MediatR;
using MediatrWithPublish.Domain;

namespace MediatrWithPublish.Application.Command.CreateOrder;

public class CreateOrderCommandHandler: IRequestHandler<CreateOrderCommand, Order>
{
    private readonly IMediator _mediator;
    
    public CreateOrderCommandHandler(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    
    public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        // Validate the request
        // Create the order in the database
        var order = new Order
        {
            Id = 1,
            CustomerName = request.CustomerName,
            Total = request.TotalAmount
        };

        // Publish a notification that the order has been created
        await _mediator.Publish(new OrderCreatedNotification() { Order  = order }, cancellationToken);

        return order;
        
    }
}