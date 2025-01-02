using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Application.Services;

public class SubscriptionsService : ISubscriptionsService
{
    public async Task<Guid> CreateSubsctoptionAsync(string subscriptionType, Guid adminId)
    {
        return await Task.FromResult(Guid.NewGuid());
    }
}
