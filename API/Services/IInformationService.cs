using API.Data;

namespace API.Services
{

    /// <summary>
    /// Interfaz que da soporte al servicio de ventanas emergentes de información de las geometrías.
    /// </summary>
    public interface IInformationService
    {
        void Register(IPeopleProvider provider);

        IPeopleProvider GetProvider(string providerName);
    }
    
}
