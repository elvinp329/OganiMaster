using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OganiMaster.MVC.DAL;
using OganiMaster.MVC.ViewModels;
using System;

namespace OganiMaster.MVC.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ContactController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var department = _dbContext.Departments.ToList();
            var contact = _dbContext.Contacts.ToList();

            var viewModel = new ContactViewModel
            {
                Departments = department,
                Contacts = contact,
            };

            return View(viewModel);
        }
    }
}
