using Gul_MVC.DatabContext;
using Gul_MVC.Models;
using Gul_MVC.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gul_MVC.Controllers
{
    public class ProductDetailsController:Controller
    {
        public readonly FiorelloDb _dbContext;

        public ProductDetailsController(FiorelloDb fiorelloDb)
        {
            _dbContext = fiorelloDb;
        }


        public async Task<IActionResult> Index1()
        {
            

            Prodact prodacts = _dbContext.Prodacts.FirstOrDefault();

            return View(prodacts);

        }



    }
}
