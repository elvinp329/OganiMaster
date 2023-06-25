using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OganiMaster.MVC.DAL;
using OganiMaster.MVC.ViewModels;
using System;

namespace OganiMaster.MVC.Controllers
{
        public class HomeController : Controller
        {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
            {
                var shop = _dbContext.Shops.ToList();
                var department = _dbContext.Departments.ToList();

                var homeViewModel = new HomeViewModel
                {
                    Departments = department,
                    Shops = shop,
                };


                return View(homeViewModel);
            }
        }
}
