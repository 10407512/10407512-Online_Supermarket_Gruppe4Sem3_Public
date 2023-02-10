using Azure;
using Microsoft.Identity.Client;
using RESTClient.DTOs;
using RestSharp;
using System.Net;

namespace RESTClient.RestClient
{
    public class OrderRestClient : IOrderClient
    {
        RestSharp.RestClient _client;

        public OrderRestClient(string baseUrl) => _client = new RestSharp.RestClient(baseUrl);
        public void InsertOrder(OrderDTO order)
        {
            var request = new RestRequest("", Method.Post);
            request.AddBody(order); //Order is converted to JSON
            _client.Post(request); 
        }
        public IEnumerable<OrderDTO>? GetAll()
        {
            return _client.Get<IEnumerable<OrderDTO>>(new RestRequest());
        }

        public void UpdateOrder(OrderDTO order)
        {
            try
            {
                var request = new RestRequest($"{order.OrderNo}");
                request.AddBody(order);
                _client.Put(request);
            }
            catch (Exception e)
            {
                Console.WriteLine("Stack: " + e.StackTrace);
                Console.WriteLine("Message: " + e.Message);
            }
        }
    }
    
}
