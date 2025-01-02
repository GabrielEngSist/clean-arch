using Microsoft.AspNetCore.Mvc;
using GymManagement.Contracts.Subscriptions;
using GymManagement.Application.Services;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    private ISubscriptionsService _subscriptionsService;

    public SubscriptionsController(ISubscriptionsService subscriptionsService)
    {
        _subscriptionsService = subscriptionsService;
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
        var subscriptionId = await _subscriptionsService.CreateSubsctoptionAsync(request.SubscriptionType.ToString(), request.AdminId);
        return Ok(new SubscriptionResponse(subscriptionId));
    }
}
