using SqlDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SqlDataAccess
{
    public interface IPeopleData
    {
        Task InsertPerson(PersonModel person);
        Task<List<PersonModel>> LoadPeople();
    }
}