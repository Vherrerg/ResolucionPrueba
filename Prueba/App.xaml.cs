using System.Windows;
using API;
using DataProvider;
using ModulePopupInfoPeople;
using Prism;
using Prism.Ioc;
using Prism.Modularity;

namespace Prueba
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App 
    {
        

        protected override Window CreateShell()
        {
            return Container.Resolve<PeopleViewerWindow>();
        }


        protected override void InitializeModules()
        {
            base.InitializeModules();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<DataProviderModule>();
            moduleCatalog.AddModule<InfoModule>();
        }
    }
}
