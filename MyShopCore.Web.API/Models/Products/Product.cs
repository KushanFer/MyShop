namespace MyShopCore.Web.API.Models.Products
{
    public class Product : Audit
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int OrderAfter { get; set; }

    }
}
