using API;
using API.Data;
using API.Services;
using ModulePopupInfoPeople.ViewModels;
using ModulePopupInfoPeople.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using DataProvider;

namespace ModulePopupInfoPeople
{
    public class InfoModule : IModule
    {

        private readonly IRegionManager _regionManager;

        public InfoModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(PeopleControl));
            var infoService = containerProvider.Resolve<IInformationService>();
            var people = containerProvider.Resolve<IPeopleProvider>();
            infoService.Register(people);

            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<PeopleControl, PeopleControlViewModel>();
            containerRegistry.RegisterSingleton<IInformationService, InformationService>();
            containerRegistry.RegisterSingleton<IPeopleProvider, PeopleProvider>();
        }
    }
}
