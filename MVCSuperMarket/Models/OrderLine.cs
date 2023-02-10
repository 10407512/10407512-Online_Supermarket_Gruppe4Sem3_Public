using RESTClient.DTOs;

namespace MVCSuperMarket.Models

    //This model class is not being used, but we're experiencing problems with running the program if 
    //we delete it anyway. DTO model is used instead.
    
{
    public class OrderLine
    {
        public int Quantity { get; set; }
        public double SubTotal { get; set; }
        public ProductDTO Product { get; set; }
        //public string Name { get; set; }
        //public string Brand { get; set; }
        //public double Price { get; set; }
        //public string ProductBarcode { get; set; }

    }
}
