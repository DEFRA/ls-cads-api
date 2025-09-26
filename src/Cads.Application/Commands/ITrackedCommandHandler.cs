using Cads.Core.Domain.BuildingBlocks.Aggregates;
using MediatR;

namespace Cads.Application.Commands;

public interface ITrackedCommandHandler<in TCommand, TResult>
    : IRequestHandler<TCommand, TrackedResult<TResult>> where TCommand
    : ICommand<TrackedResult<TResult>>
{
}