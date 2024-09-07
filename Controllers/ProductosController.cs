using Inventario.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Controllers
{
    public class ProductosController: Controller
    {
        private readonly AppDbContext _context;

        public ProductosController(AppDbContext context) { 
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var productos = await _context.Productos.ToListAsync();
            return View(productos);
        }
    }
}
