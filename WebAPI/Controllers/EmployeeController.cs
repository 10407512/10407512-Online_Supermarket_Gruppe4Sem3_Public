using Microsoft.AspNetCore.Mvc;
using DataAccess.DataAccess;
using DataAccess.Model;
using RESTClient.DTOs;
using RESTClient.DTOs.Converters;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    { 

        IPersonDAO _employeeDao = new PersonDAO();
    
        [HttpGet]
        public IEnumerable<PersonDTO> GetAll()
        {
            return _employeeDao.GetAllEmployees().ToDtos();
        }


        [HttpGet("{userName}/getByUserName")]
        public ActionResult<PersonDTO> GetByUserName(string userName)
        {
            Person? person = _employeeDao.GetByUserName(userName);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person.ToDto());
        }



        [HttpPost]
        public ActionResult Post(PersonDTO person)
        {
            bool success = _employeeDao.Insert(person.FromDto());
            if (!success)
            {
                return BadRequest();
            }
            return Ok(person);
        }

        [HttpPut("{email}")]
        public ActionResult Put(string email, PersonDTO person)
        {
            bool successs = _employeeDao.Update(email, person.FromDto());
            if (!successs)
            {
                return BadRequest();
            }
            return Ok(person);
        }


        [HttpDelete]
        public ActionResult DeleteEmployee(string email)
        {
            Person? person = _employeeDao.GetByEmail(email);
            if (person == null)
            {
                return NotFound();
            }
            _employeeDao.Delete(person, email);

            var response = new HttpResponseMessage();
            response.Headers.Add("DeleteMessage", "Succsessfully Deleted!!!");
            return Ok(response);
        }

    }
}
