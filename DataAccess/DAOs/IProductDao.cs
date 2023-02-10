using DataAccess.Model;


namespace DataAccess.DataAccess
{
    public interface IProductDAO
    {
        IEnumerable<Product> GetAll();
        Product? GetByName(String name);
        Product? GetByBarcode(String barcode);
        bool Insert(Product entity);
        bool Update(Product entity, string barcode);
        bool Delete(Product entity);
        bool UpdateStock(Product product, string barcode);
    }
}
