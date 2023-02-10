using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class OrderLine
    {
        public int Quantity { get; set; }
        public double SubTotal { get; set; }
        public Product Product { get; set; }


        public OrderLine(int quantity, double subTotal, Product product)
        {
            Quantity = quantity;
            Product = product;
            SubTotal = Quantity * Product.Price;
        }

        //For converters
        public OrderLine()
        {
            
        }
    }
}
