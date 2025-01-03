using GymManagement.Domain.Subscriptions;

namespace GymManagement.Application.Common.Interfaces;

public interface ISubscriptionsRespository
{
    Task AddSubscriptionAsync(Subscription subscription);
}
