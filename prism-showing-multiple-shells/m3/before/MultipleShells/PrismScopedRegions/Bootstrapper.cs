﻿using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using ModuleA;
using PrismScopedRegions.Infrastructure;
using System;
using System.Globalization;
using System.Reflection;

namespace PrismScopedRegions
{
    public class Bootstrapper : UnityBootstrapper
    {
        public Bootstrapper()
        {
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                var viewName = viewType.FullName;
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                var viewModelName = String.Format(CultureInfo.InvariantCulture, "{0}ViewModel, {1}", viewName, viewAssemblyName);
                return Type.GetType(viewModelName);
            });
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            ViewModelLocationProvider.SetDefaultViewModelFactory((type) =>
            {
                return Container.Resolve(type);
            });
        }

        protected override System.Windows.DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(ModuleAModule));
        }
    }
}
