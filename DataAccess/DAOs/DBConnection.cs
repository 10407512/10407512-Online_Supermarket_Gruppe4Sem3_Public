using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace DataAccess.DataAccess
{
    public class DBConnection
    {
        protected readonly IConfiguration _configuration;
        public DBConnection()
        {
            _configuration = new ConfigurationBuilder().SetBasePath(Path.GetFullPath("../DataAccess")).AddJsonFile("config.json").Build();
        }
    }
}
