using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Order
    {
        private static int maxAttempts = 3;

        public int OrderNo { get; set; }
        public double Total { get; set; }
        public DateTime Date { get; set; }
        public bool IsReady { get; set; }
        public bool IsColleceted { get; set; }
        public bool IsPaid { get; set; }

        public string OrderCreatorKey { get; set; }
        public string HandlerKey { get; set; }

        public Person? Person { get; set; }
        //public Employee Handler { get; set; }

        public List<OrderLine> OrderLines { get; set; }
        public int MaxAttempts { get => maxAttempts; set => maxAttempts = value; }

        public Order(int orderNo, double total, DateTime date, bool isReady, bool isColleceted, bool isPaid, string orderCreatorKey, string handlerKey, List<OrderLine> orderLines)
        {
            OrderNo = orderNo;
            Total = total;
            Date = date;
            IsReady = isReady;
            IsColleceted = isColleceted;
            IsPaid = isPaid;
            OrderCreatorKey = orderCreatorKey;
            HandlerKey = handlerKey;
            OrderLines = orderLines;
        }

        public Order() //is used for DTOConverter when an orderDTO is converted to an order object.
        {
            
        }


		//Methods down below are used for future implementation of the Order class.

		//public double GetTotal()
		//{
		//    Total = 0;
		//    foreach (OrderLine ol in OrderLines)
		//    {
		//        AddToTotal(ol);
		//        //Total += ol.SubTotal;
		//    }
		//    return Total;
		//}

		//public double AddToTotal(OrderLine orderLine) => Total += orderLine.UpdateSubtotal();

		//public void AddOrderline(OrderLine orderLine)
		//{
		//    OrderLines.Add(orderLine);
		//    AddToTotal(orderLine);
		//}
	}
}
