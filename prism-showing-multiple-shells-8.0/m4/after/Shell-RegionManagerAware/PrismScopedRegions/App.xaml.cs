using System.Windows;

using ModuleA;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

using PrismScopedRegions.Infrastructure;

namespace PrismScopedRegions
{
    public partial class App : PrismApplication
    {

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule(typeof(ModuleAModule));

            base.ConfigureModuleCatalog(moduleCatalog);
        }
        
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell(Window shell)
        {
            var regionManager = RegionManager.GetRegionManager((Shell));
            RegionManagerAware.SetRegionManagerAware(Shell, regionManager);
            
            base.InitializeShell(shell);
            
            // var regionManager = RegionManager.GetRegionManager((Shell));
            // RegionManagerAware.SetRegionManagerAware(Shell, regionManager);            
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IShellService, ShellService>();
        }
    }
}
