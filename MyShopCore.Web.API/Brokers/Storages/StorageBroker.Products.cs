using Microsoft.EntityFrameworkCore;
using MyShopCore.Web.API.Models.Products;

namespace MyShopCore.Web.API.Brokers.Storages
{
    public partial class StorageBroker 
     {
        public DbSet<Product> Products { get; set; }
        public async ValueTask<Product> DeleteProductAsync(Product product)
        {
            this.Entry(product).State = EntityState.Deleted;
            await this.SaveChangesAsync();
            return product;
        }


      
        public async ValueTask<Product> InsertProductAsync(Product product)
        {
           this.Entry(product).State = EntityState.Added;  // Below Way is instead of this line           
           // OR USE THIS LINE this.Products.Add(product);
            await this.SaveChangesAsync();
            return product;
        }

        public IQueryable<Product> SelectAllProducts()
        {
            return this.Products.AsQueryable();
        }

        public  async ValueTask<Product> SelectProductByIDAsync(Guid productId)
        {
            return await this.Products.FindAsync(productId);
        }

        public async ValueTask<Product> UpdateProductAsync(Product product)
        {
            this.Entry(product).State= EntityState.Modified;
            await this.SaveChangesAsync();
            return product;
        }
    }
}
