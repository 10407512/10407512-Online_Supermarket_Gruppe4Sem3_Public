//using DataAccess.DataAccess;
//using DataAccess.Model;
//using Microsoft.AspNetCore.Mvc;

// ***** THIS CLASS IS ACTIVATED WHEN WE WANT TO HAVE CUSTOMERS IN THE DATABASE *****

//namespace WebAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CustomerController : ControllerBase
//    {
//        [HttpGet]
//        public IEnumerable<Person> GetAll()
//        {
//            var persons = new PersonDao();
//            return persons.GetAllCustomers();
//        }


//        [HttpGet("{email}/getByEmail")]
//        public ActionResult GetByEmail(string email)
//        {
//            var requestedPerson = new PersonDao();
//            Person? person = requestedPerson.GetByEmail(email);
//            if (person == null)
//            {
//                return NotFound();
//            }
//            return Ok(person);
//        }


//        [HttpPost]
//        public ActionResult Post(Person person)
//        {
//            var personToCreate = new PersonDao();
//            personToCreate.Insert(person);
//            return Ok(person);
//        }

//        [HttpPut("{email}")]
//        public ActionResult Put(Person person)
//        {
//            var personToUpdate = new PersonDao();
//            personToUpdate.Update(person);
//            return Ok(person);
//        }

//        [HttpDelete]
//        public ActionResult<Employee> DeleteCustomer(Person entity, string email)
//        {
//            var cus = new PersonDao();
//            try
//            {
//                var customerToDelete = cus.GetByUserName(email);

//                if (customerToDelete == null)
//                {
//                    return NotFound();
//                }
//                cus.Delete(entity, email);
//                return Ok(customerToDelete);
//            }
//            catch (Exception)
//            {
//                return StatusCode(400, "Error deleting customer");
//            }
//        }
//    }
//}
