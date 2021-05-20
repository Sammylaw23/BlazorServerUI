using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IPeopleData
    {
        Task InsertPerson(PersonModel person);
        Task<List<PersonModel>> GetPeople();
    }
}