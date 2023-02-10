using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTClient.RestClient;

namespace MVCSuperMarket.Controllers
{
    public class ProductController : Controller
    {
        IProductClient _client = new ProductRestClient("https://localhost:7067/api/Product");
        //IProductClient _client = new ProductRestClient("http://79.171.148.188/api/Product");

        public ActionResult Index() => View(_client.GetAll());

        public ActionResult Details(string barcode)
        {
            return View(_client.GetByBarcode(barcode));
        }
    }
}
