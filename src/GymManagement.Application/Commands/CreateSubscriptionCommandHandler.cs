using ErrorOr;
using MediatR;

namespace GymManagement.Application.Commands;

public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Guid>>
{
    public async Task<ErrorOr<Guid>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(Guid.NewGuid());
    }
}
