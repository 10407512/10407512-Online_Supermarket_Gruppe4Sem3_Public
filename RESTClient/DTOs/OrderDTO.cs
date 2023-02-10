using DataAccess.Model;

namespace RESTClient.DTOs
{
    public class OrderDTO
    {
        public int OrderNo { get; set; }
        public double Total { get; set; }
        public DateTime Date { get; set; }
        public bool IsReady { get; set; }
        public bool IsColleceted { get; set; }
        public bool IsPaid { get; set; }
        //public string OrderCreatorKey { get; set; }
        //public string HandlerKey { get; set; }
        public List<OrderLineDTO> OrderLines { get; set; }
        public PersonDTO? Person { get; set; }
    }
}