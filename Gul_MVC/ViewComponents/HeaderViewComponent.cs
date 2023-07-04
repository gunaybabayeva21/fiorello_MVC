using Gul_MVC.DatabContext;
using Gul_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gul_MVC.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly FiorelloDb _fiorelloDb;
        

        public HeaderViewComponent(FiorelloDb fiorelloDb)
        {
            _fiorelloDb = fiorelloDb;
            
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Dictionary<string, Setting> settings = await _fiorelloDb.Settings.ToDictionaryAsync(s => s.Key);
            return View(settings);
        }

       
    }
}
