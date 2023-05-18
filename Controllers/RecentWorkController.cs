using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebFrontToBack.DAL;
using WebFrontToBack.Models;
using WebFrontToBack.ViewModel;


namespace WebFrontToBack.Controllers
{
    public class RecentWorkController : Controller
    {
        protected readonly AppDbContext _context;

        public RecentWorkController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            return View( await _context.RecentWorks.ToListAsync());
        }
    }
}
