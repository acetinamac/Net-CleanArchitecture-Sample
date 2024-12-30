using Ardalis.Specification;

namespace CleanArchitecture.Sample.SharedKernel.Interfaces;
// from Ardalis.Specification
public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
