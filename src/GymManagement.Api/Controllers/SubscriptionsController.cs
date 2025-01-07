using Microsoft.AspNetCore.Mvc;
using GymManagement.Contracts.Subscriptions;
using MediatR;
using GymManagement.Application.Commands;
using GymManagement.Application.Queries;
using DomainSubscriptionType = GymManagement.Domain.Subscriptions.SubscriptionType;
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

    [HttpGet("{subscriptionId:guid}")]
    public async Task<IActionResult> GetSubscriptionsAsync([FromRoute] Guid subscriptionId)
    {
        var query = new GetSubscription(subscriptionId);
        var getSusbcriptionResult = await _mediator.Send(query);

        return getSusbcriptionResult.Match(
            subscription => Ok(
                new SubscriptionResponse(subscription.Id, Enum.Parse<SubscriptionType>(subscription.SubscriptionType.Name))),
            errors => Problem()
        );
    }

    [HttpPost]
    public async Task<IActionResult> CreateSubscriptionAsync([FromBody] CreateSubscriptionRequest request)
    {
        if (!DomainSubscriptionType.TryFromName(
            request.SubscriptionType.ToString(),
            out var subscriptionType))
        {
            return Problem(
                statusCode: 404,
                detail: "Invalid subscription type"
            );
        }

        var command = new CreateSubscriptionCommand(
            subscriptionType,
            request.AdminId);

        var createSubscriptionResult = await _mediator.Send(command);

        return createSubscriptionResult.Match(
            subscription => Ok(new SubscriptionResponse(subscription.Id, request.SubscriptionType)),
            errors => Problem()
        );
    }
}
