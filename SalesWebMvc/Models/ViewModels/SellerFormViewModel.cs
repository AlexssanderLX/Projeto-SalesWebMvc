namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Sellers Seller { get; set; }
        public ICollection<Departament> Departaments { get; set; }
    }
}
