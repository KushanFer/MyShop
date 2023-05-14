namespace MyShopCore.Web.API.Models
{
    public class Audit
    {
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
