using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Customer.Data;

namespace MVC_Customer.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext db)
        {
            _context = db;
        }
        public IActionResult Index()
        {
            var customersWithItems = _context.Customers.Include(c => c.Items).ToList();
            return View(customersWithItems);
        }
    }
}
