using Microsoft.EntityFrameworkCore;
using MyShopCore.Web.API.Models.Products;

namespace MyShopCore.Web.API.Brokers.Storages
{
    public partial class StorageBroker  : DbContext,IStorageBroker
    {

        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)  //Constructor
        {
            this.configuration = configuration;
        }

      

        /// <summary>
        /// Create Connection String for the DB
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionstring);  //K-THIS WILL TELL USING SQL. If Need to Change to Oracle ..Change to Oracle
        }
    }
}
