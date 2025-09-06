using InventoryWebApp.Data;
using InventoryWebApp.DTOs;
using InventoryWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryWebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemsController : ControllerBase
{
    private readonly InventoryDBContext _context;

    public ItemsController(InventoryDBContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<List<Item>>> GetItems()
    {
        var items = await _context.Items.ToListAsync();
        return Ok(items);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Item>> GetItemById(int id)
    {
        var item = await _context.Items.FindAsync(id);
        if (item == null)
        {
            return NotFound();
        }
        return Ok(item);
    }

    [HttpGet("nostock")]
    public async Task<ActionResult<List<Item>>> GetNoStockItems()
    {
        var items = await _context.Items.Where(x => x.Stock == 0).ToListAsync();
        if (items == null)
        {
            return NotFound();
        }
        
        return Ok(items);
    }
    [HttpPost]
    public async Task<ActionResult<Item>> AddItem(Item newItem)
    {
        if (newItem == null)
        {
            return BadRequest("No item to add");
        }

        if (newItem.Name.Length < 1)
        {
            return BadRequest("Item name cannot be empty");
        }

        if (newItem.Price <= 0)
        {
            return BadRequest("Price cannot be zero or negative");
        }

        if (newItem.Stock <= 0)
        {
            return BadRequest("Stock cannot be zero or negative");
        }
        
        await _context.Items.AddAsync(newItem);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetItemById), new { id = newItem.Id }, newItem);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateItem(int id, Item updatedItem)
    {
        var item = _context.Items.Find(id);
        if (item == null)
        {
            return NotFound();
        }
        
        item.Id = updatedItem.Id;
        item.Name = updatedItem.Name;
        item.Description = updatedItem.Description;
        item.Stock = updatedItem.Stock;
        item.Price = updatedItem.Price;
        
        await _context.SaveChangesAsync();
        
        return NoContent();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> PartialUpdateItem(int id, [FromBody] UpdateItemResponse updateItemResponse)
    {
        var item = _context.Items.Find(id);
        if (item == null)
        {
            return NotFound();
        }

        if (updateItemResponse.Name == "")
        {
            return BadRequest("Product name cannot be empty.");
        }
        if (updateItemResponse.Price < 1)
        {
            return BadRequest("Please enter a valid price.");
        }
        
        item.Name = updateItemResponse.Name;
        item.Description = updateItemResponse.Description;
        item.Price = updateItemResponse.Price;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPatch("{id}/stock/update")]
    public async Task<IActionResult> UpdateItemStock(int id, [FromBody] UpdateStockResponse stock)
    {
        var item = _context.Items.Find(id);
        if (item == null)
        {
            return NotFound();
        }
        
        int oldStock = item.Stock;
        
        item.Stock = stock.Stock;
        item.UpdatedAt = DateTime.Now;
        
        StockLog stockLog = new StockLog
        {
            ItemId = id,
            CreatedAt = DateTime.Now,
            OldStock = oldStock,
            NewStock = stock.Stock,
        };
        await _context.StockLogs.AddAsync(stockLog);
        await _context.SaveChangesAsync();
        
        return CreatedAtAction(nameof(GetItemById), new { id = id }, item);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteItem(int id)
    {
        var item = await _context.Items.FindAsync(id);
        if (item == null)
        {
            return NotFound();
        }
        
        _context.Items.Remove(item);
        await _context.SaveChangesAsync();
        return NoContent();
    }
    
}