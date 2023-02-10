using RESTClient.DTOs;

namespace RESTClient.RestClient
{
    public interface IOrderClient
    {
        IEnumerable<OrderDTO>? GetAll();
        void InsertOrder(OrderDTO order);
        void UpdateOrder(OrderDTO order);

    }
}
