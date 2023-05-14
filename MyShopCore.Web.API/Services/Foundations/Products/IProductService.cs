using MyShopCore.Web.API.Models.Products;

namespace MyShopCore.Web.API.Services.Foundations.Products
{


    /// <summary>
    /// Use Business Terms in Naming here. In Broker We use DB Terms Like Select UPdate Delete
    /// </summary>
    public interface IProductService
    {
        ValueTask<Product> AddProductAsync(Product product);
        IQueryable<Product> RetrieveAllProducts();
        ValueTask<Product> ReceiveProductByIDAsync(Guid id);
        ValueTask<Product> ModifyProductAsync(Product product);
        ValueTask<Product> RemoveProductAsync(Product product);
    }
}
