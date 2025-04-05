using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
    public class ProducersController : Controller
    {
        private AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allProducers = _context.Producers.ToList();
            return View(allProducers);
        }
    }
}
