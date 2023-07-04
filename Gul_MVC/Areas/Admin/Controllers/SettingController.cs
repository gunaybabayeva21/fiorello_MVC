using Gul_MVC.DatabContext;
using Gul_MVC.Models;
using Gul_MVC.ViewModels.SettingVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gul_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController:Controller
    {
        private readonly FiorelloDb _fiorelloDb;

        public SettingController(FiorelloDb fiorelloDb)
        {
           _fiorelloDb = fiorelloDb;
        }

        public async Task< IActionResult> Index(int id) 
        {
            List<Setting> settings = await _fiorelloDb.Settings.ToListAsync();
            {
                return View(settings);
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            Setting?setting=await _fiorelloDb.Settings.FirstOrDefaultAsync(x => x.Id == id);
            if(setting == null) return View(null);
            EditSettingVM editSettingVM = new EditSettingVM()
            {
                Value = setting.Value
            };
            return View(editSettingVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditSettingVM editSettingVM)
        {
            Setting? setting = await _fiorelloDb.Settings.FirstOrDefaultAsync(x => x.Id == id);
            if (setting == null) return View();
            if(!ModelState.IsValid) return View();
            setting.Value = editSettingVM.Value;
           _fiorelloDb.Settings.Update(setting);
            await _fiorelloDb.SaveChangesAsync();
            return RedirectToAction("Index");


        }
    }
}
