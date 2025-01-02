using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.Application.Services;

public interface ISubscriptionsService
{
    Task<Guid> CreateSubsctoptionAsync(string subscriptionType, Guid adminId);
}
