using SqlDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess _db;

        public PeopleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> LoadPeople()
        {
            string sql = "select * from dbo.People";
            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @"insert into dbo.People (FirstName,LastName,EmailAddress)
                            values (@FirstName,@LastName,@EmailAddress);";

            return _db.SaveData(sql, person);
        }
    }
}
