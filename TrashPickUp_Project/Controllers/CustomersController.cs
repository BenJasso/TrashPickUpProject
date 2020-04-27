using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrashPickUp_Project.Data;
using TrashPickUp_Project.Models;

namespace TrashPickUp_Project.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context1;

        public CustomersController(ApplicationDbContext context1)
        {
            _context1 = context1;
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customer = _context1.Users.Where(u => u.Email == User.Identity.Name).SingleOrDefault();
            var id = customer.Id;
            if (_context1.Customers.Where(e => e.IdentityUserId == id).SingleOrDefault() == null)
            {
                return View("Create");
            }
            else
            {
                return View();
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Customer newCustomer = new Customer();
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                newCustomer.IdentityUserId = userId;
                newCustomer.Name = collection["Name"].ToString();
                _context1.Customers.Add(newCustomer);
                _context1.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}