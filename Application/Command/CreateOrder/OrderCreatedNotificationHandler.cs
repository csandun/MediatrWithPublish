using MediatR;

namespace MediatrWithPublish.Application.Command.CreateOrder;

public class OrderCreatedNotificationHandler : INotificationHandler<OrderCreatedNotification>
{
    private readonly ILogger<OrderCreatedNotificationHandler> _logger;

    public OrderCreatedNotificationHandler(ILogger<OrderCreatedNotificationHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(OrderCreatedNotification notification, CancellationToken cancellationToken)
    {
        // Send a confirmation email
        _logger.LogInformation($"Confirmation email sent for order {notification.Order.Id}");

        return Task.CompletedTask;
    }
}