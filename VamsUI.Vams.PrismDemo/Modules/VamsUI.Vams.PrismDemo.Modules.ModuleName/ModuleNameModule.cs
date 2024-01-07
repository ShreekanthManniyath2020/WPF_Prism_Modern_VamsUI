using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using VamsUI.Vams.PrismDemo.Core;
using VamsUI.Vams.PrismDemo.Modules.ModuleName.Views;

namespace VamsUI.Vams.PrismDemo.Modules.ModuleName
{
    public class ModuleNameModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ModuleNameModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "ViewA");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
        }
    }
}