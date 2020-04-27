using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TrashPickUp_Project.Models;
using TrashPickUp_Project.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace TrashPickUp_Project.Controllers

{
    
    [Authorize(Roles = "Employee")]
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context1;
        public EmployeesController(ApplicationDbContext context1)
        {
            _context1 = context1;
        }
        public ActionResult ScheduledPickUps()
        {
            return View();
        }

        // GET: Employees
        public ActionResult Index()
        {
            var employee = _context1.Users.Where(u => u.Email == User.Identity.Name).SingleOrDefault();
            var id = employee.Id;
            if (_context1.Employees.Where(e => e.IdentityUserId == id).SingleOrDefault() == null)
            {
                return View("Create"); 
            }
            else
            {
                return View();
            }
           
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Employee newEmployee = new Employee();
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                newEmployee.IdentityUserId = userId;
                newEmployee.Name = collection["Name"].ToString();
                _context1.Employees.Add(newEmployee);
                _context1.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employees/Edit/5
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

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employees/Delete/5
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