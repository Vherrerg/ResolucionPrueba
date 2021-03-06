using API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.Services;

namespace ModulePopupInfoPeople
{
    internal class InformationService : IInformationService
    {

        private List<IPeopleProvider> providers;
        


        public InformationService()
        {
            providers = new List<IPeopleProvider>();
        }


        public void Register(IPeopleProvider provider)
        {
            providers.Add(provider);
        }

        public IPeopleProvider GetProvider(string providerName)
        {
            var pr = providers.FirstOrDefault(p => p.ProviderName.Equals(providerName, StringComparison.InvariantCultureIgnoreCase));
            if (pr != null)
                return pr;
            return null;
        }

        
    }
}
