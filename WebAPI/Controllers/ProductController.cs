using Azure;
using DataAccess.DataAccess;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using RESTClient.DTOs;
using RESTClient.DTOs.Converters;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductDAO _productDao = new ProductDAO();
        HttpResponseMessage response = new HttpResponseMessage();

        [HttpGet]
        public IEnumerable<ProductDTO> GetAll()
        {
            return _productDao.GetAll().ToDtos();
        }


        [HttpGet("{barcode}")]
        public ActionResult<ProductDTO> GetByBarcode(string barcode)
        {
            var product = _productDao.GetByBarcode(barcode);
            if (product != null)
            {
                return Ok(product.ToDto());
            }
            response.Headers.Add("ErrorMessage", "Product not found!!!");
            return NotFound(response);
        }

        [HttpPut("{barcode}")]
        public ActionResult Put(ProductDTO product, string barcode)
        {
            bool success = _productDao.Update(product.FromDto(), barcode);
            if (!success)
            {
                return BadRequest();
            }
            return Ok(product);
        }

        [HttpPut("{barcode}/updateStock")]
        public ActionResult PutStock(ProductDTO product, string barcode)
        {
            bool success = _productDao.UpdateStock(product.FromDto(), barcode);
            if (!success)
            {
                return BadRequest();
            }
            return Ok(product);
        }

        [HttpPost]
        public ActionResult Post(ProductDTO product)
        {
           bool success = _productDao.Insert(product.FromDto());
            if (!success)
            {
                return BadRequest(); 
            }
            return Ok(product);
        }

        [HttpDelete("{barcode}")]
        public ActionResult Delete(string barcode)
        {
            
            Product? product = _productDao.GetByBarcode(barcode);
            if (product == null)
            {
                return NotFound();
            }
            _productDao.Delete(product);

            response.Headers.Add("DeleteMessage", "Successfully Deleted!!!");
            return Ok(response);
        }
    }
}
