using Gul_MVC.DatabContext;
using Gul_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gul_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController:Controller
    {
       
        private readonly FiorelloDb _fiorelloDb;

        public CategoryController(FiorelloDb fiorelloDb)
        {
            _fiorelloDb=fiorelloDb;
        }

        public async Task<IActionResult> Index()
        {
            List<Catagory> categories = await _fiorelloDb.catagory.ToListAsync();
            return View(categories);

        }

        public async Task<IActionResult> Detail(int id)
        {
            Catagory? catagory = await _fiorelloDb.catagory.FindAsync(id);
            if (catagory == null)
            {
                return NotFound();
            }
            return View(catagory);
        }

        [HttpGet]
        public IActionResult Create() 
        { 
          return View();
        
        }

        [HttpPost]
        public async Task<IActionResult> Create(Catagory catagory) 
        { 
            
           if(!ModelState.IsValid) 
           {
                return View();
           }
            if (_fiorelloDb.catagory.Any(c => c.Name.Trim().ToLower() == catagory.Name.Trim().ToLower()))
            {
                ModelState.AddModelError("Name","Catagory already exist");
                return View();
            }

           await _fiorelloDb.catagory.AddAsync(catagory);
           await _fiorelloDb.SaveChangesAsync();  
            

          return View();

        }
        public async Task<IActionResult> Delete(int id)
        {

            Catagory? catagory = await _fiorelloDb.catagory.FindAsync(id);
            if(catagory == null)
            {
                return NotFound();
            }
            _fiorelloDb.catagory.Remove(catagory);
            await _fiorelloDb.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]

        public async Task<IActionResult>Update()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiforgerytoken]

        public async  Task<IActionResult>Update(Catagory newcatagory)
        {
            Catagory catagory = await _fiorelloDb.catagory.FindAsync(newcatagory.Id);
            if (catagory == null)
            {
                return NotFound();
            }

            if(!ModelState.IsValid) 
            {
                return View();
            
            }
            if (_fiorelloDb.catagory.Any(c => c.Name.Trim().ToLower() == newcatagory.Name.Trim().ToLower()))
            {
                ModelState.AddModelError("Name", "Catagory already exist!");
                return View();
            }
            catagory.Name = newcatagory.Name;
            _fiorelloDb.Update(catagory);
            await _fiorelloDb.SaveChangesAsync();
            return View();
        }
        



    }
}
