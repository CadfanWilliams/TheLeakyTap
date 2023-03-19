using Microsoft.AspNetCore.Mvc;
using TheLeakyTap.Data;
using TheLeakyTap.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheLeakyTap.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookingController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        //Returns a ENUM of list for a table view of all bookings
        //eventually we will only return bookings matching the account
        //Index
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Booking> bookingList = _db.Bookings.ToList();
            return View(bookingList);
        }
    }
}

