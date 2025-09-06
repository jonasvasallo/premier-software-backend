namespace InventoryWebApp.DTOs;

public class UpdateItemResponse
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
}