using System.Collections.Generic;
using System.Windows.Documents;
using API.Data;
using API.Services;
using DataProvider;
using Model;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;

namespace ModulePopupInfoPeople.ViewModels
{
    public class PeopleControlViewModel: BindableBase
    {
        private IInformationService _service;
        private IContainerProvider _containerProvider;
        private string _nombreProvider;
        public PeopleControlViewModel(IInformationService service, IContainerProvider containerProvider)
        {
            _service = service;

            _containerProvider = containerProvider;
            _nombreProvider = _containerProvider.Resolve<IPeopleProvider>().ProviderName;
        }

        private string _text = "Prueba Command Binding";
        public string Texto
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public DelegateCommand GetDataCommand
        {
            get
            {
                return new DelegateCommand(SetPeople);            
            }
        }

        private List<Person> _people;

        public List<Person> People { get { return _people; } set {
                SetProperty(ref _people, value);
            } }

        public void SetPeople()
        {
            People = _service.GetProvider(_nombreProvider).GetPeople();
          
        }


    }
}
