﻿using Prism.Modularity;
using Prism.Regions;
using Modules.Admin.Views;

namespace Modules.Admin
{
    public class AdminModule : IModule
    {
        IRegionManager _regionManager;
        public AdminModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(AdminView));
        }
    }
}
