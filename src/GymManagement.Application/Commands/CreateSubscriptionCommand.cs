using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorOr;
using GymManagement.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Commands;

public record CreateSubscriptionCommand(string SubscriptionType, Guid AdminId) : IRequest<ErrorOr<Subscription>>;