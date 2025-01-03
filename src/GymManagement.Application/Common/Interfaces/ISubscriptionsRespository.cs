using GymManagement.Domain.Subscriptions;

namespace GymManagement.Application.Common.Interfaces;

public interface ISubscriptionsRespository
{
    Task AddSubscriptionAsync(Subscription subscription, CancellationToken cancellationToken = default);
    Task<Subscription?> GetSubscriptionByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
