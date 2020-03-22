using Caliburn.Micro;
using DI.EventSetup.UI.Main;

namespace DI.EventSetup.UI.Configuration
{
    public static class DependenciesConfigurator
    {
        public static void AddAllDependencies(this SimpleContainer container)
        {
            container.AddStaticDependencies();
            container.AddServicesDependencies();
            container.AddRepositoryDependencies();
        }

        private static void AddStaticDependencies(this SimpleContainer container)
        {
            container.PerRequest<MainViewModel>();
            container.PerRequest<IWindowManager, WindowManager>();
        }

        private static void AddServicesDependencies(this SimpleContainer container)
        {
        }

        private static void AddRepositoryDependencies(this SimpleContainer container)
        {
        }
    }
}
