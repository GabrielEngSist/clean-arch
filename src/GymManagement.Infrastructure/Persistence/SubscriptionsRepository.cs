using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;

namespace GymManagement.Infrastructure.Persistence;

public class SubscriptionsRepository : ISubscriptionsRespository
{
    private static readonly List<Subscription> _subscriptions = new();
    public async Task AddSubscriptionAsync(Subscription subscription, CancellationToken cancellationToken = default)
    {
        _subscriptions.Add(subscription);
        await Task.CompletedTask;
    }

    public async Task<Subscription?> GetSubscriptionByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var subscription = _subscriptions.FirstOrDefault(s => s.Id == id);
        return await Task.FromResult(subscription);
    }
}
