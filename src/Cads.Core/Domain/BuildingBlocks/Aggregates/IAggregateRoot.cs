using Cads.Core.Repositories;

namespace Cads.Core.Domain.BuildingBlocks.Aggregates;

public interface IAggregateRoot : IEntity
{
    IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
    void ClearDomainEvents();
}