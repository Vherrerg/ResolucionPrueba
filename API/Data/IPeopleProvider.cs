using System.Collections.Generic;
using Model;

namespace API.Data
{
    public interface IPeopleProvider
    {
        string ProviderName { get; }

        List<Person> GetPeople();
    }
}