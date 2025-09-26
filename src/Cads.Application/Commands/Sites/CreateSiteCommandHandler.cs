using Cads.Core.Documents;
using Cads.Core.Domain.BuildingBlocks.Aggregates;
using Cads.Core.Domain.Sites;
using Cads.Core.Repositories;

namespace Cads.Application.Commands.Sites;

/// <summary>
/// Example implementation only. To remove in future stories.
/// </summary>
/// <param name="repository"></param>
public class CreateSiteCommandHandler(IGenericRepository<SiteDocument> repository)
    : ITrackedCommandHandler<CreateSiteCommand, string>
{
    private readonly IGenericRepository<SiteDocument> _repository = repository;

    public async Task<TrackedResult<string>> Handle(CreateSiteCommand request, CancellationToken cancellationToken)
    {
        var site = Site.Create(Guid.NewGuid().ToString(), "Holding", request.Name, "England");
        site.AddSiteIdentifier(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), "CPH");

        var document = SiteDocument.FromDomain(site);
        await _repository.AddAsync(document, cancellationToken);

        return new TrackedResult<string>(site.Id, site);
    }
}