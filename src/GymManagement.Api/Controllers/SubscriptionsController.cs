using Microsoft.AspNetCore.Mvc;
using GymManagement.Contracts.Subscriptions;
using MediatR;
using GymManagement.Application.Commands;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    private ISender _mediator;

    public SubscriptionsController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetSubscriptionsAsync()
    {
        // Placeholder for actual implementation
        return await Task.FromResult(Ok(new List<string> { "Subscription1", "Subscription2" }));
    }

    [HttpPost]
    public async Task<IActionResult> CreateSubscriptionAsync([FromBody] CreateSubscriptionRequest request)
    {
        var command = new CreateSubscriptionCommand(request.SubscriptionType.ToString(), request.AdminId);
        var subscriptionId = await _mediator.Send(command);
        return Ok(new SubscriptionResponse(subscriptionId, request.SubscriptionType));
    }
}
