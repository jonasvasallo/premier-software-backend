using InventoryWebApp.Data;
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

    [HttpPost]
    public async Task<ActionResult<Item>> AddItem(Item newItem)
    {
        if (newItem == null)
        {
            return BadRequest();
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
        item.Quantity = updatedItem.Quantity;
        item.Price = updatedItem.Price;
        
        await _context.SaveChangesAsync();
        
        return NoContent();
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