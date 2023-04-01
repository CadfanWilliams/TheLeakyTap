using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheLeakyTap.Areas.Identity.Data;
using TheLeakyTap.Data;
using TheLeakyTap.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheLeakyTap.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public string UserID;
  
        public BookingController(ApplicationDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
            

        }

        
        // GET: /<controller>/
        //Returns a ENUM of list for a table view of all bookings
        //eventually we will only return bookings matching the account
        //Index
        [HttpGet]
        public IActionResult Index()
        {
            var UserID = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            IEnumerable<Booking> bookingList = _db.Bookings.ToList();
            IEnumerable<Booking> query = bookingList.Where(bookingList => bookingList.userId == UserID);
            return View(query);
        }

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Booking obj)
        {

            var UserID = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            obj.userId = UserID.ToString();
            if (ModelState.IsValid)
            {
                
                
                _db.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        #endregion

        #region Update
        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id != null || id != 0)
            {
                var bookingFromId = _db.Bookings.Find(id);
                if (bookingFromId != null)
                {
                    return View(bookingFromId);

                }
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Update(Booking obj)
        {
            if (ModelState.IsValid)
            {
                _db.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        #endregion

        #region Delete

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id != 0 || id != null)
            {
                var obj = _db.Bookings.Find(id);
                if (obj != null)
                {
                    return View(obj);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Booking obj)
        {
            if (obj != null)
            {
                _db.Bookings.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        #endregion
    }
}




