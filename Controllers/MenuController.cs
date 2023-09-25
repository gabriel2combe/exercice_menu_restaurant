using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi;
using WebApi.Data;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

[Route("api/[controller]")]
[ApiController]
public class MenuController : ControllerBase
{
    private readonly RestaurantDbContext _context;

    public MenuController(RestaurantDbContext context)
    {
        _context = context;
    }

    // GET: api/Menu
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Menu>>> GetMenus()
    {
        return await _context.Menus.ToListAsync();
    }
    /*
    // GET: api/Menu/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Menu>> GetMenu(int id)
    {
        var menu = await _context.Menus.Include(m => m.Meals).FirstOrDefaultAsync(m => m.Id == id);

        if (menu == null)
        {
            return NotFound();
        }

        return menu;
    }
    */
}