using DataAccess.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public interface IOrderLineDAO
    {
        IEnumerable<OrderLine> GetAllOrderLinesOnOrder(int orderNo);
        bool Insert(int orderNo, OrderLine orderLine, SqlTransaction transaction, SqlConnection sqlConnection);
    }
}
