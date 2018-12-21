using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaloonApp.AppointmentService;
using SaloonApp.DB;
using SaloonApp.DTOs;
using SaloonApp.Extensions;
using SaloonApp.Models;
using SaloonApp.UserDom.Domain;
using SaloonApp.UserDom.Domain.Models;
using SaloonApp.UserService;

namespace SaloonApp.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context = new AppDbContext();
        private UserManager _userManager = new UserManager();
        private AppointmentManager _appManager = new AppointmentManager();

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string date)
        {
            if (!HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn"))
                return View();
            SetVariables();
            HttpContext.Session.SetObjectAsJson<string>("ForUserID", "");

            var dateToShow = SetDate(date);
            var users = await _context.Users.ToListAsync();
            users = users.Where(u => u.FullName != "Ivan Gabrov").ToList();
            var homeEntry = new HomeEntry
            {
                OpenHours = new List<List<string>>(),
                ForDate = dateToShow,
                Users = new List<User>()
            };

            foreach (var user in users)
            {
                List<string> openHoursForCurrentUser = new List<string>();
                homeEntry.OpenHours.Add(openHoursForCurrentUser);
                homeEntry.Users.Add(user);

                var app = await _appManager.GetAllAppointmentsByUserIdAndDate(user.Id, dateToShow);

                for (int i = 0; i < app.Count; i++)
                {
                    app[i].AppointmentDrutation = app[i].AppointmentDrutation.Substring(0, 11);

                    var app1 = app[i].AppointmentDrutation.Substring(app[i].AppointmentDrutation.Length - 5);
                    if (i == 0)
                    {
                        var a = app[i].AppointmentDrutation.Substring(0, 5);
                        if (a != "12:00")
                            openHoursForCurrentUser.Add($"12:00 - {a}");
                    }
                    if (i == app.Count - 1)
                    {
                        var hour = int.Parse(app1.Substring(0, 2));
                        if (hour < 20)
                            openHoursForCurrentUser.Add($"{app1} - 20:00");
                        break;
                    }
                    var app2 = app[i + 1].AppointmentDrutation.Substring(0, 5);
                    if (app1 != app2)
                    {
                        openHoursForCurrentUser.Add($"{app1} - {app2}");
                    }
                }
                if (app.Count == 0)
                    openHoursForCurrentUser.Add("12:00 - 20:00");
            }

            
            return View(homeEntry);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void SetVariables()
        {
            ViewData["UserName"] = HttpContext.Session.GetObjectFromJson<string>("UserName");
            ViewData["IsSignedIn"] = HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn");
            ViewData["TypeOfUser"] = HttpContext.Session.GetObjectFromJson<TypeOfUser>("TypeOfUser");
        }

        private DateTime SetDate(string date)
        {
            var dateToShow = DateTime.Now.Date;
            if (date != null)
            {
                List<string> nums = date.Split('/').ToList();
                var year = int.Parse(nums[2]);
                var month = int.Parse(nums[0]);
                var day = int.Parse(nums[1]);
                dateToShow = new DateTime(year, month, day);
            }
            return dateToShow;
        }
    }
}
