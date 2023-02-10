using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Numerics;

namespace DataAccess.Model
{
    public class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Barcode { get; set; }


        public Product(string name, string brand, double price, string description, int stock, string barcode)
        {
            Name = name;
            Brand = brand;
            Price = price;
            Description = description;
            Stock = stock;
            Barcode = barcode;
        }

        public Product() //is used for DTOConverter when a productDTO is converted to a product object.
        {

        }

		//This method converts a product object to string and is only used if we need to
		//print out the information of a product object in the console
		public override string ToString()
        {
            return $"Name - {Name}\n" +
                   $"Brand - {Brand}\n" +
                   $"Price - {Price}\n" +
                   $"Description {Description}\n" +
                   $"Stock - {Stock}\n" +
                   $"barcode - {Barcode}\n";
        }
    }
}