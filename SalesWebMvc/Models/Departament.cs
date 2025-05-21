using System.Linq;
namespace SalesWebMvc.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Sellers> Sellers { get; set; } = new List<Sellers>();

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Departament()
        {
        }
        public void AddSeller(Sellers s)
        {
            Sellers.Add(s);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller =>  seller.TotalSales(initial, final));
        }
    }
}
