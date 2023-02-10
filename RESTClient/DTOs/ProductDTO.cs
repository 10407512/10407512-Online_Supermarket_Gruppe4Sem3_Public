namespace RESTClient.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Barcode { get; set; } = string.Empty;
    }
}
