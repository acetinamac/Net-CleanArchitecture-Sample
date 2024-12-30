using Ardalis.Specification;

namespace CleanArchitecture.Sample.SharedKernel.Interfaces;
public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
