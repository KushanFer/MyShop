using Microsoft.EntityFrameworkCore;
using MyShopCore.Web.API.Models.Products;

namespace MyShopCore.Web.API.Brokers.Storages
{
    public partial class StorageBroker 
     {
        public DbSet<Product> Products { get; set; }
        public ValueTask<Product> DeleteProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> InsertProductAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> SelectAllProducts()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> SelectProductByIDAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
