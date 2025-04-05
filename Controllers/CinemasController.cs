using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
    public class CinemasController : Controller
    {
        private AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allCinemas = _context.Cinemas.ToList(); 
            return View(allCinemas);
        }
    }
}
