namespace InventoryWebApp.Models;

public class StockLog
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public DateTime CreatedAt { get; set; }
    public int OldStock { get; set; }
    public int NewStock { get; set; }
    
    public Item Item { get; set; }
}