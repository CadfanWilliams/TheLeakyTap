using Microsoft.AspNetCore.Mvc;
using TheLeakyTap.Data;
using TheLeakyTap.Models;

using Microsoft.AspNetCore.Identity;
using TheLeakyTap.Areas.Identity.Data;



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

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Booking obj)
        {
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


    

