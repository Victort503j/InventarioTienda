namespace InventarioTienda.Models
{
    public class SalesDetails
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
        public int VentaId { get; set; }
        public Sale Venta { get; set; } 
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
