using Autofac;
using CleanArchitecture.Sample.Core.Interfaces;
using CleanArchitecture.Sample.Core.Services;

namespace CleanArchitecture.Sample.Core;
public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();

    builder.RegisterType<DeleteContributorService>()
        .As<IDeleteContributorService>().InstancePerLifetimeScope();
  }
}
