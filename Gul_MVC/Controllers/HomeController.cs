using Gul_MVC.DatabContext;
using Gul_MVC.Models;
using Gul_MVC.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Gul_MVC.Controllers
{
    public class HomeController : Controller
    {
        public readonly FiorelloDb _dbContext;

        public HomeController(FiorelloDb fiorelloDb)
        {
             _dbContext = fiorelloDb;
        }
        
        public async Task<IActionResult> Index()
        {
            List<Prodact> prodacts = await _dbContext.Prodacts.ToListAsync();
            List<Catagory> catagories = await _dbContext.catagory.ToListAsync();

            HomeVm homeVm = new HomeVm()
            {
                Prodacts = prodacts,
                Catagories = catagories
            };
            return View(homeVm);
        }

        
        
        

        
    }
}