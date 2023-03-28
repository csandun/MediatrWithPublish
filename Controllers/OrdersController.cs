using MediatR;
using MediatrWithPublish.Application.Command.CreateOrder;
using MediatrWithPublish.Domain;
using Microsoft.AspNetCore.Mvc;

namespace MediatrWithPublish.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController: ControllerBase
{

    private readonly IMediator _mediator;
    
    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost]
    public async Task<Order> Create([FromBody] CreateOrderCommand command)
    {
        var order = await _mediator.Send(command);
        return order;
    }
}