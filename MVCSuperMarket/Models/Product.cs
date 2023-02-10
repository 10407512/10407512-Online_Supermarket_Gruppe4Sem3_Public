namespace MVCSuperMarket.Models
{

	//This model class is not being used, but we're experiencing problems with running the program if 
	//we delete it anyway. DTO model is used instead.
	public class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Barcode { get; set; }
    }
}
