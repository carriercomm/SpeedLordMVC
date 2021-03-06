using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using SpeedLord.Interfaces.Repositories;
using SpeedLord.Repositories.Fake;

namespace SpeedLord
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
        container.RegisterType<IAccountRepository, FakeAccountRepository>();
        container.RegisterType<ICombatRepository, FakeCombatRepository>();
        container.RegisterType<IMonsterRepository, FakeMonsterRepository>();
        container.RegisterType<IAbilityRepository, FakeAbilityRepository>();
        container.RegisterType<ICharacterRepository, FakeCharacterRepository>();
    }
  }
}