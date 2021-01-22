using System;
using System.Windows;

using Prism.Ioc;
using Prism.Unity;

namespace PrismScopedRegions
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);
        //    Bootstrapper bs = new Bootstrapper();
        //    bs.Run();
        //}
        protected override Window CreateShell()
        {
            throw new NotImplementedException();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            throw new NotImplementedException();
        }
    }
}
