using DataAccess.Model;
using RESTClient.DTOs;

namespace RESTClient.DTOs
{
    public class OrderLineDTO
    {
        public int Quantity { get; set; }
        public double SubTotal { get; set; }
        public ProductDTO Product { get; set; }
    }
}
