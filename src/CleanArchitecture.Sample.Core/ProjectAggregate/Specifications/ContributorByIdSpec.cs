using Ardalis.Specification;
using CleanArchitecture.Sample.Core.ContributorAggregate;

namespace CleanArchitecture.Sample.Core.ProjectAggregate.Specifications;
public class ContributorByIdSpec : Specification<Contributor>, ISingleResultSpecification
{
  public ContributorByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
