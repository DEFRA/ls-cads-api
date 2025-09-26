using Cads.Core.Domain.BuildingBlocks.Aggregates;

namespace Cads.Application.Commands.Sites;

/// <summary>
/// Example implementation only. To remove in future stories.
/// </summary>
/// <param name="Name"></param>
public record CreateSiteCommand(string Name) : ICommand<TrackedResult<string>>;