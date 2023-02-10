using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public interface IPersonDAO
    {
        IEnumerable<Person> GetAllEmployees();
        Person GetByEmail(string email);  
        Person GetByUserName(string userName);
        bool Insert(Person entity);
        bool Update(string email, Person entity);
        bool Delete(Person entity, string email);
    }
}
