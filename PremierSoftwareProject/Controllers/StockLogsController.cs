using InventoryWebApp.Data;
using InventoryWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryWebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StockLogsController : ControllerBase
{
    private readonly InventoryDBContext _context;

    public StockLogsController(InventoryDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<StockLog>> GetStockLogs()
    {
        var logs = await _context.StockLogs.ToListAsync();
        
        return Ok(logs);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<StockLog>>> GetStockLogOfProduct(int id)
    {
        var logs = await _context.StockLogs
            .Where(log => log.ItemId == id)
            .OrderByDescending(log => log.CreatedAt)
            .ToListAsync();
        return Ok(logs);
    }
}