﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using RentAHousband.ViewModels;
using RentAHousband.Models;


namespace RentAHousband.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult ShowCustomer()
        {

            /*var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            var listCustomers = new ShowCustomerViewModel
            {
                CustomersList = customers
            };

            return View(customers);*/

            if (User.IsInRole(RoleName.CanManageHousbands))
                return View("ShowCustomer");

            return View("ReadOnlyShowCustomer");
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {

            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        [Authorize(Roles = RoleName.CanManageHousbands)]
        public ActionResult New()
        {
            var membershipType = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipType
            };

            return View("CustomerForm", viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageHousbands)]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = new Customer(),
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }


            if (customer.Id == 0)
                {
                    _context.Customers.Add(customer);
                }
                else
                {
                    var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                    customerInDb.Name = customer.Name;
                    customerInDb.Birthdate = customer.Birthdate;
                    customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                    customerInDb.MembershipTypeId = customer.MembershipTypeId;


                }
                _context.SaveChanges();

                return RedirectToAction("ShowCustomer", "Customers");
            
        }

        [Authorize(Roles = RoleName.CanManageHousbands)]
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            };

            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}