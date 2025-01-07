using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using GymManagement.Infrastructure.Common.Persistence;

namespace GymManagement.Infrastructure.Persistence;

public class SubscriptionsRepository : ISubscriptionsRespository
{
    private GymManagementDbContext _dbContext;

    public SubscriptionsRepository(GymManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task AddSubscriptionAsync(Subscription subscription, CancellationToken cancellationToken = default)
    {
        await _dbContext.AddAsync(subscription, cancellationToken);
    }

    public async Task<Subscription?> GetSubscriptionByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var subscription = await _dbContext.Subscriptions.FindAsync(id);
        return subscription;
    }
}
