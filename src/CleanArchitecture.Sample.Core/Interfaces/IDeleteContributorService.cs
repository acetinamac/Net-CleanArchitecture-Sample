using Ardalis.Result;

namespace CleanArchitecture.Sample.Core.Interfaces;
public interface IDeleteContributorService
{
  public Task<Result> DeleteContributor(int contributorId);
}
