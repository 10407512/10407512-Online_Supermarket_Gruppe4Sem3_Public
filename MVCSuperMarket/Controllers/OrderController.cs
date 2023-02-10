using Microsoft.AspNetCore.Mvc;
using RESTClient.DTOs;
using RESTClient.DTOs.Converters;
using RESTClient.RestClient;
using Newtonsoft.Json;
using System.Reflection;
using Microsoft.Data.SqlClient;

namespace MVCSuperMarket.Controllers
{
    public class OrderController : Controller
    {
		IOrderClient _client = new OrderRestClient("https://localhost:7067/api/Order");
		//IOrderClient _client = new OrderRestClient("http://79.171.148.188/api/Order");

        // GET: OrderController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckOut(string Email, string PhoneNo, string FName, string LName)
        {
            PersonDTO person = new PersonDTO()
            {
                F_name = FName,
                L_name = LName,
                PhoneNo = PhoneNo,
                Email = Email
            };
			//we serialize the person object to a json string
			TempData["NewCustomer"] = JsonConvert.SerializeObject(person); ;
            return RedirectToAction("Payment", TempData["NewCustomer"]);
        }



        [HttpGet]
        public ActionResult Payment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Payment(string CardNo, string ExpirationDate, string Cvc)
        {
            var person = JsonConvert.DeserializeObject<PersonDTO>((string)TempData["NewCustomer"]);
            OrderDTO order = CreateOrder(person);
            try
            {
                _client.InsertOrder(order);
                TempData.Remove("ErrorMessage");
            }
            catch (Exception)
            {
                TempData.Add("ErrorMessage", "Something went wrong please try again");
                return RedirectToAction("Payment");
            }
            return RedirectToAction("Confirmation");
        }

        [HttpGet]
        public ActionResult Confirmation()
        {
            return View();
        }

        public OrderDTO CreateOrder(PersonDTO person)
        {
            OrderDTO orderDTO = new OrderDTO()
            {
                Person = person,
                OrderLines = JsonConvert.DeserializeObject<List<OrderLineDTO>>(HttpContext.Session.GetString("SessionCart"))
            };
            orderDTO.OrderLines.ForEach(ol => orderDTO.Total += ol.SubTotal);
            return orderDTO;
        }
    }
}