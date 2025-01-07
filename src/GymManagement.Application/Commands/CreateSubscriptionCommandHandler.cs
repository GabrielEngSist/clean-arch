using ErrorOr;
using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Commands;

public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Subscription>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISubscriptionsRespository _subscriptionRepository;

    public CreateSubscriptionCommandHandler(ISubscriptionsRespository subscriptionRepository, IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _subscriptionRepository = subscriptionRepository;
    }
    public async Task<ErrorOr<Subscription>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
    {
        var subscription = new Subscription(request.SubscriptionType, request.AdminId);

        await _subscriptionRepository.AddSubscriptionAsync(subscription, cancellationToken);
        await _unitOfWork.CommitChangesAsync(cancellationToken);

        return subscription;
    }
}
