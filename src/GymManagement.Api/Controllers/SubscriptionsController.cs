using Microsoft.AspNetCore.Mvc;
using GymManagement.Contracts.Subscriptions;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetSubscriptionsAsync()
    {
        // Placeholder for actual implementation
        return await Task.FromResult(Ok(new List<string> { "Subscription1", "Subscription2" }));
    }
    [HttpPost]
    public async Task<IActionResult> CreateSubscriptionAsync([FromBody] CreateSubscriptionRequest request)
    {
        return await Task.FromResult(Ok(request));
    }
}
