using RESTClient.DTOs;

namespace RESTClient.RestClient
{
    public interface IProductClient
    {
        IEnumerable<ProductDTO>? GetAll();
        ProductDTO GetByBarcode(string barcode);
    }
}
