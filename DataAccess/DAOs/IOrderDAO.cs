using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public interface IOrderDAO
    {
        IEnumerable<Order> GetAll();
        Order GetByOrderNo(int orderNo);
        bool Insert(Order entity);
        bool Update(int orderNo, Order entity);
        bool Delete(int orderNo);
    }
}
