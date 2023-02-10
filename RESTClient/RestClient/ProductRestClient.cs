using RESTClient.DTOs;   
using RestSharp;

namespace RESTClient.RestClient
{
    public class ProductRestClient : IProductClient
    {
        RestSharp.RestClient _client;

        public ProductRestClient(string baseUrl) => _client = new RestSharp.RestClient(baseUrl);


        public IEnumerable<ProductDTO>? GetAll()
        {
            return _client.Get<IEnumerable<ProductDTO>>(new RestRequest());
        }
        
        public ProductDTO GetByBarcode(string barcode)
        {
            return _client.Get<ProductDTO>(new RestRequest($"{barcode}"));
        }
    }
}
