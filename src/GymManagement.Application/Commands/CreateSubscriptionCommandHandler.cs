using MediatR;

namespace GymManagement.Application.Commands;

public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, Guid>
{
    public async Task<Guid> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(Guid.NewGuid());
    }
}
