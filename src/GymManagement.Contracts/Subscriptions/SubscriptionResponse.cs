namespace GymManagement.Contracts.Subscriptions;

public class SubscriptionResponse
{
    public Guid SubscriptionId { get; private set; }
    public SubscriptionType SubscriptionType { get; private set; }

    public SubscriptionResponse(Guid subscriptionId, SubscriptionType subscriptionType)
    {
        SubscriptionId = subscriptionId;
        SubscriptionType = subscriptionType;
    }
}
