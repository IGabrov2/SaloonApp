using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaloonApp.DB;
using SaloonApp.Extensions;
using SaloonApp.UDF;
using SaloonApp.UDF.Domain;
using SaloonApp.UserDom.Domain;

namespace SaloonApp.Controllers
{
    public class UDFController : Controller
    {
        private AppDbContext _context = new AppDbContext();
        private UDFManager _UDFManager = new UDFManager();

        public UDFController(AppDbContext context)
        {
            _context = context;
        }
        public static bool sex;

        public IActionResult Index(bool m = false)
        {
            if (HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn") == false)
                return RedirectToAction("LogIn", "Account");
            SetVariables();
            sex = m;
            var AdminUDF = _UDFManager.GetAdminUDFAsync(sex).Result;

            return View("SettingsUDF", AdminUDF);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUDF(AdminUDF entry)
        {
            if (HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn") == false)
                return RedirectToAction("LogIn", "Account");
            SetVariables();
            entry.Male = sex;
            var AdminUDF = _UDFManager.GetAdminUDFAsync(entry.Male).Result;
            AdminUDF = _UDFManager.UpdateAdminUDFHelper(entry,AdminUDF.ID);

            _context.Update(AdminUDF);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }


        private void SetVariables()
        {
            ViewData["UserName"] = HttpContext.Session.GetObjectFromJson<string>("UserName");
            ViewData["IsSignedIn"] = HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn");
            ViewData["TypeOfUser"] = HttpContext.Session.GetObjectFromJson<TypeOfUser>("TypeOfUser");
        }
    }
}