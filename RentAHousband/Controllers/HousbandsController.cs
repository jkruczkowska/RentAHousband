using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using RentAHousband.Models;
using RentAHousband.ViewModels;

namespace RentAHousband.Controllers
{
    public class HousbandsController : Controller
    {
        private ApplicationDbContext _context;

        public HousbandsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Housbands/Show
        [Route("housbands/show")]
        public ActionResult Show()
        {
            var listOfHousbands = _context.Housbands.Include(h => h.PersonalityType).ToList();
     
            var viewModel = new ShowHousbandViewModel()
            {
                Housbands = listOfHousbands
            };

            return View(listOfHousbands);
        }


        [Route("Housbands/HousDetails/{id}")]
        public ActionResult HousDetails(int id)
        {
            var housband = _context.Housbands.SingleOrDefault(h => h.Id == id);


            if (housband == null)
            {
                return HttpNotFound();

            }
            return View(housband);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Housband housband)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new NewHousbandViewModel(housband)
                {
                    PersonalityTypes = _context.PersonalityTypes.ToList()
                };
                return View("HousbandForm", viewModel);
            }

            if (housband.Id == 0)
            {
                _context.Housbands.Add(housband);
            }
            else
            {
                var housbandInDb = _context.Housbands.Include(h => h.PersonalityType).Single(h => h.Id == housband.Id);

                housbandInDb.Name = housband.Name;
                housbandInDb.SkillName = housband.SkillName;
                housbandInDb.Age = housband.Age;
                housbandInDb.IsBearded = housband.IsBearded;
                housbandInDb.PersonalityTypeId = housband.PersonalityTypeId;


            }
            _context.SaveChanges();

            return RedirectToAction("Show", "Housbands");
        }

        [Authorize(Roles = RoleName.CanManageHousbands)]
        public ActionResult Edit(int id)
        {
            var housband = _context.Housbands.SingleOrDefault(c => c.Id == id);

            if (housband == null)
            {
                return HttpNotFound();
            };

            var viewModel = new NewHousbandViewModel(housband)
            {                
                PersonalityTypes = _context.PersonalityTypes.ToList()
            };

            return View("HousbandForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageHousbands)]
        public ActionResult New()
        {
            var personalityType = _context.PersonalityTypes.ToList();
            var viewModel = new NewHousbandViewModel()
            {
                PersonalityTypes = personalityType
            };

            return View("HousbandForm", viewModel);
        }
    }
}
