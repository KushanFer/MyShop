using MyShopCore.Web.API.Brokers.DateTimes;
using MyShopCore.Web.API.Brokers.Loggings;
using MyShopCore.Web.API.Brokers.Storages;
using MyShopCore.Web.API.Models.Products;

namespace MyShopCore.Web.API.Services.Foundations.Products
{
    public class ProductService : IProductService
    {
            private readonly IStorageBroker _storageBroker;
        private readonly ILoggingBroker _loggingBroker;
        private readonly IDateTimeBroker _dateTimeBroker;

        public ProductService( ILoggingBroker loggingBroker, IStorageBroker _storageBroker, IDateTimeBroker _dateTimeBroker)
        {
        this._loggingBroker = loggingBroker;
            this._storageBroker = _storageBroker;
                this._dateTimeBroker = _dateTimeBroker;
        }

        public async ValueTask<Product> AddProductAsync(Product product)
        {
            this._loggingBroker.LogInformation($"{product.Name}  Added");
            product.Id = Guid.NewGuid();
            product.Created = _dateTimeBroker.GetCurrentDateTime();
            product.CreatedBy = Guid.NewGuid();

            return await this._storageBroker.InsertProductAsync(product);
        }

        public  async ValueTask<Product> ModifyProductAsync(Product product)
        {
            this._loggingBroker.LogInformation($"{product.Name}  Modified");
            return await this._storageBroker.UpdateProductAsync(product);
        }

        public ValueTask<Product> ReceiveProductByIDAsync(Guid id)
        {
            return this._storageBroker.SelectProductByIDAsync(id);
        }

        public async ValueTask<Product> RemoveProductAsync(Product product)
        {
            this._loggingBroker.LogInformation($"{product.Name} removed");
            return await this._storageBroker.DeleteProductAsync(product);
        }

        public IQueryable<Product> RetrieveAllProducts()
        {
            return this._storageBroker.SelectAllProducts();
        }
    }
}
