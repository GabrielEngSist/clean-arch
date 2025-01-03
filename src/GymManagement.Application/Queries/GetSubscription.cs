using ErrorOr;
using GymManagement.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Queries;

public record GetSubscription(Guid Id) : IRequest<ErrorOr<Subscription?>>;