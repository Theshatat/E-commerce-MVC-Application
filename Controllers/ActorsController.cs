using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
    public class ActorsController : Controller
    {
        private AppDbContext _context;
        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allActors = _context.Actors.ToList();
            return View(allActors);
        }
    }
}
