namespace GymManagement.Contracts.Subscriptions;

public class SubscriptionResponse
{
    public Guid SubscriptionId { get; set; }

    public SubscriptionResponse(Guid subscriptionId)
    {
        SubscriptionId = subscriptionId;
    }
}
