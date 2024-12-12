namespace InventarioTienda.Models
{
    public class Box
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string Type { get; set; }
        public decimal Start { get; set; }
        public decimal End { get; set; }
    }
}
