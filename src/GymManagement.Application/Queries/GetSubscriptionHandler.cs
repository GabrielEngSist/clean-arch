using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorOr;
using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Queries;

public class GetSubscriptionHandler : IRequestHandler<GetSubscription, ErrorOr<Subscription?>>
{
    private ISubscriptionsRespository _subscriptionsRespository;
    private IUnitOfWork? _unitOfWork;

    public GetSubscriptionHandler(ISubscriptionsRespository subscriptionsRespository, IUnitOfWork? unitOfWork = default)
    {
        _subscriptionsRespository = subscriptionsRespository;
        _unitOfWork = unitOfWork;
    }
    public async Task<ErrorOr<Subscription?>> Handle(GetSubscription request, CancellationToken cancellationToken)
    {
        var subscription = await _subscriptionsRespository.GetSubscriptionByIdAsync(request.Id, cancellationToken);

        return subscription is null ?
            Error.NotFound(description: "Subscription not found") :
            subscription;
    }
}
