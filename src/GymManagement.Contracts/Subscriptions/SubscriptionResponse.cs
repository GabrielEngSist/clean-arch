namespace GymManagement.Contracts.Subscriptions;

public class SubscriptionResponse
{
    public Guid SubscriptionId { get; init; }
    public SubscriptionType SubscriptionType { get; init; }

    public SubscriptionResponse(Guid subscriptionId, SubscriptionType subscriptionType)
    {
        SubscriptionId = subscriptionId;
        SubscriptionType = subscriptionType;
    }
}
