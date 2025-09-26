using MediatR;

namespace Cads.Core.Domain.BuildingBlocks;

public interface IDomainEvent : INotification
{
    DateTime OccurredOn { get; }
}