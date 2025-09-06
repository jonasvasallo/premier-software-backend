namespace InventoryWebApp.Models;

public class Sale
{
    public int Id { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int UnitsSold { get; set; }
    
    public decimal SellingPrice { get; set; }
    public int ItemId { get; set; }
}