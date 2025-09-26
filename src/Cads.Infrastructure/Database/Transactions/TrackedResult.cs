using Cads.Core.Domain.BuildingBlocks.Aggregates;

namespace Cads.Infrastructure.Database.Transactions;

public class TrackedResult<T>(T result, params IAggregateRoot[] aggregates) : ITrackedResult
{
    public T Result { get; } = result;
    public IReadOnlyCollection<IAggregateRoot> Aggregates { get; } = aggregates;
}