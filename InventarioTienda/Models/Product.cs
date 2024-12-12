namespace InventarioTienda.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal LastCost { get; set; }
        public decimal Utility { get; set; }
        public decimal PriceSale { get; set; }
        public decimal WholesalePrice { get; set; }
        public decimal SpecialPrice { get; set; }
        public bool HasInventory { get; set; }
        public int Stock { get; set; }
        public int InitialStock { get; set; }
        public int MinimumStock { get; set; }
        public bool IsActive { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; } 
        public int CategoryId { get; set; }
        public Category Category { get; set; } 
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
