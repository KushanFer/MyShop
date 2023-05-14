using MyShopCore.Web.API.Models.Products;

namespace MyShopCore.Web.API.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Product> InsertProductAsync(Product product);
        IQueryable<Product> SelectAllProducts();
        ValueTask<Product> SelectProductByIDAsync(Guid id);
        ValueTask<Product> UpdateProductAsync(Product product);
        ValueTask<Product> DeleteProductAsync(Product product);

    }
}
