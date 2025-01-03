using ErrorOr;
using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Commands;

public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Subscription>>
{
    private readonly ISubscriptionsRespository _subscriptionRepository;

    public CreateSubscriptionCommandHandler(ISubscriptionsRespository subscriptionRepository)
    {
        _subscriptionRepository = subscriptionRepository;
    }
    public async Task<ErrorOr<Subscription>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
    {
        var subscription = new Subscription { Id = Guid.NewGuid() };
        await _subscriptionRepository.AddSubscriptionAsync(subscription);
        return await Task.FromResult(subscription);
    }
}
