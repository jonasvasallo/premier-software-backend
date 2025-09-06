using InventoryWebApp.Data;
using InventoryWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryWebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SalesController : ControllerBase
{
    private readonly InventoryDBContext _context;

    public SalesController(InventoryDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Sale>>> GetSales()
    {
        var sales = await _context.Sales.ToListAsync();
        return Ok(sales);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Sale>> GetSaleById(int id)
    {
        var sale = await _context.Sales.FindAsync(id);
        if (sale == null)
        {
            return NotFound();
        }
        return sale;
    }

    [HttpPost]
    public async Task<ActionResult<Sale>> CreateSale(Sale newSale)
    {
        var item = await _context.Items.FindAsync(newSale.ItemId);
        if (item == null)
        {
            return BadRequest("Item not found.");
        }

        if (item.Stock < newSale.UnitsSold)
        {
            return BadRequest("Not enough stock.");
        }
        
        newSale.SellingPrice = item.Price;
        item.Stock = item.Stock - newSale.UnitsSold;
        
        _context.Sales.Add(newSale);
        await _context.SaveChangesAsync();
        
        return CreatedAtAction(nameof(GetSaleById), new { id = newSale.Id }, newSale);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSale(int id)
    {
        var sale = await _context.Sales.FindAsync(id);
        if (sale == null)
        {
            return NotFound();
        }
        _context.Sales.Remove(sale);
        await _context.SaveChangesAsync();
        return NoContent();
    }
    
}