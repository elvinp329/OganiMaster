using Microsoft.AspNetCore.Mvc;
using OganiMaster.MVC.DAL;
using OganiMaster.MVC.ViewModels;
using System;

namespace OganiMaster.MVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ShopController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var shop = _dbContext.Shops.ToList();
            var department = _dbContext.Departments.ToList();

            var shopViewModel = new ShopViewModel
            {
                Departments = department,
                Shops = shop,
            };


            return View(shopViewModel);
        }
        public IActionResult Details(int? id)
        {
            return View();
        }
    }
}
