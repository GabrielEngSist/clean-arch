using GymManagement.Application.Common.Interfaces;
using GymManagement.Infrastructure.Common.Persistence;
using GymManagement.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ISubscriptionsRespository, SubscriptionsRepository>();
        services.AddDbContext<GymManagementDbContext>(
            options => { options.UseSqlite("Data Source=GymManagement.db"); }
        );
        return services;
    }
}
