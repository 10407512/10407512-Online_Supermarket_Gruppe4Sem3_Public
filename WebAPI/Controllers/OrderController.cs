using DataAccess.DataAccess;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using RESTClient.DTOs;
using RESTClient.DTOs.Converters;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderDAO _orderDao = new OrderDAO();
        [HttpGet]
        public IEnumerable<OrderDTO> GetAll()
        {
            return _orderDao.GetAll().ToDtos();
        }
        
        [HttpGet("{orderNo}")]
        public ActionResult<OrderDTO> GetByOrderNo(int orderNo)
        {
            var order = _orderDao.GetByOrderNo(orderNo).ToDto();
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }


        [HttpPost]
        public ActionResult Post(OrderDTO order)
        {
            bool res = _orderDao.Insert(order.FromDto());
            if (!res)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPut("{orderNo}")]
        public IActionResult Put([FromRoute]int orderNo, [FromBody] OrderDTO order)
        {
            bool res = _orderDao.Update(orderNo, order.FromDto());
            if (!res)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("{orderNo}")]
        public ActionResult Delete(int orderNo)
        {
            Order? order = _orderDao.GetByOrderNo(orderNo);
            if (order == null)
            {
                return NotFound();
            }
            _orderDao.Delete(orderNo);

            var response = new HttpResponseMessage();
            response.Headers.Add("DeleteMessage", "Successfully Deleted!!!");
            return Ok(response);
        }
    }
}
