using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTClient.RestClient;
using RESTClient.DTOs;
using DataAccess.Model;
using Newtonsoft.Json;
//using MvcSupermarket.Models;

namespace MVCSuperMarket.Controllers
{
    public class OrderLineController : Controller
    {
        List<OrderLineDTO> _orderLines = new();

        IProductClient _client = new ProductRestClient("https://localhost:7067/api/Product");
        //IProductClient _client = new ProductRestClient("http://79.171.148.188/api/Product");

        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("SessionCart") != null)
            {
                GetCart();
            }
            return View(_orderLines);
        }

        public ActionResult Details(string Barcode)
        {
            GetCart();
            return View(_orderLines.First(orderLine => orderLine.Product.Barcode == Barcode));
        }

        [HttpPost]
        public ActionResult AddToCart(int Quantity, string Barcode)
        {
            var product = _client.GetByBarcode(Barcode);

            if (HttpContext.Session.GetString("SessionCart") != null)
            {
                GetCart();
            }

            var checkOrderLine = _orderLines.FirstOrDefault(orderLine => orderLine.Product.Barcode == product.Barcode);
            if (checkOrderLine != null)
            {
                checkOrderLine.Quantity += Quantity;
                checkOrderLine.SubTotal = checkOrderLine.Quantity * product.Price;
            }
            else
            {
                OrderLineDTO orderLine = new OrderLineDTO();
                orderLine.Product = product;
                orderLine.Quantity = Quantity;
                orderLine.SubTotal = orderLine.Quantity * product.Price;
                _orderLines.Add(orderLine);
            }
            SaveCart();
            return RedirectToRoute(new { action = "Index", controller = "product" });
        }

        public ActionResult Edit(string Barcode)
        {
            GetCart();
            return View(_orderLines.First(orderLine => orderLine.Product.Barcode == Barcode));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OrderLineDTO editedOrderLine)
        {
            try
            {
                GetCart();
                var orderLine = _orderLines.First(orderLine => orderLine.Product.Barcode == editedOrderLine.Product.Barcode);
                orderLine.Quantity = editedOrderLine.Quantity;
                SaveCart();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(string Barcode)
        {
            GetCart();
            return View(_orderLines.First(orderLine => orderLine.Product.Barcode == Barcode));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfimation(string Barcode)
        {
            try
            {
                GetCart();
                _orderLines.RemoveAll(orderLine => orderLine.Product.Barcode == Barcode);
                SaveCart();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public void GetCart() => _orderLines = JsonConvert.DeserializeObject<List<OrderLineDTO>>(HttpContext.Session.GetString("SessionCart"));
        public void SaveCart() => HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(_orderLines));
    }
}
