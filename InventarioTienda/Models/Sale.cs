namespace InventarioTienda.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public int IdCaja { get; set; }
        public Box Caja { get; set; } 
        public int IdUser { get; set; }
        public User User { get; set; } 
        public int IdCustomer { get; set; }
        public Customer Customer { get; set; } 
        public ICollection<SalesDetails> SalesDetails { get; set; }
    }
}
