using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManagement.Domain.Subscriptions;
using Microsoft.EntityFrameworkCore;

namespace GymManagement.Infrastructure.Common.Persistence;

public class GymManagementDbContext : DbContext
{
    public DbSet<Subscription> Subscriptions { get; set; } = null!;

    public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options) : base(options)
    {
    }
}
