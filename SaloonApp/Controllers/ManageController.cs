using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SaloonApp.AppointmentService;
using SaloonApp.Common.Extensions;
using SaloonApp.DB;
using SaloonApp.DTOs;
using SaloonApp.Extensions;
using SaloonApp.Models;
using SaloonApp.Models.ManageViewModels;
using SaloonApp.Services;
using SaloonApp.UserDom.Domain;
using SaloonApp.UserDom.Domain.Models;
using SaloonApp.UserService;

namespace SaloonApp.Controllers
{
    public class ManageController : Controller
    {
        private AppDbContext _context = new AppDbContext();
        private UserManager _userManager = new UserManager();
        private AppointmentManager _appManager = new AppointmentManager();

        public ManageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult ManageUsersRoles()
        {
            if ((int)HttpContext.Session.GetObjectFromJson<TypeOfUser>("TypeOfUser") > 2 || (int)HttpContext.Session.GetObjectFromJson<TypeOfUser>("TypeOfUser") == 0)
                return RedirectToAction("Index", "Manage");
            SetVariables();
            return View();
        }

        public async Task<IActionResult> Index(string date, string userID)
        {
            if (!HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn"))
                return RedirectToAction("Login", "Account");
            SetVariables();

            if (userID == null)
                userID = HttpContext.Session.GetObjectFromJson<string>("UserId");

            var dateToShow = SetDate(date);

            var app = await _appManager.GetAllAppointmentsByUserIdAndDate(userID, dateToShow);
            var str = new FreeTimes
            {
                OpenHours = new List<string>(),
                ForDate = dateToShow
            };

            for (int i = 0; i < app.Count; i++)
            {
                app[i].AppointmentDrutation = app[i].AppointmentDrutation.Substring(0, 11);

                var app1 = app[i].AppointmentDrutation.Substring(app[i].AppointmentDrutation.Length - 5);
                if (i == 0)
                {
                    var a = app[i].AppointmentDrutation.Substring(0, 5);
                    if (a != "12:00")
                        str.OpenHours.Add($"12:00 - {a}");
                }
                if (i == app.Count - 1)
                {
                    var hour = int.Parse(app1.Substring(0, 2));
                    if (hour < 20)
                        str.OpenHours.Add($"{app1} - 20:00");
                    return View(str);
                }
                var app2 = app[i + 1].AppointmentDrutation.Substring(0, 5);

                var a1 = new TimeSpan(int.Parse(app1.Substring(0, 2)), int.Parse(app1.Substring(app1.Length-2)),0);
                var a2 = new TimeSpan(int.Parse(app2.Substring(0, 2)), int.Parse(app2.Substring(app2.Length - 2)), 0);
                if (a1 < a2)
                {
                    str.OpenHours.Add($"{app1} - {app2}");
                }
            }
            str.OpenHours.Add("12:00 - 20:00");
            return View(str);
        }

        public async Task<IActionResult> AllUsers()
        {
            if ((int)HttpContext.Session.GetObjectFromJson<TypeOfUser>("TypeOfUser") > 2 || (int)HttpContext.Session.GetObjectFromJson<TypeOfUser>("TypeOfUser") == 0)
                return RedirectToAction("Index", "Manage");
            SetVariables();
            var users = await _userManager.GetAllUsersAsync();
            return View(users.Where(u => u.FullName != "Ivan Gabrov").OrderBy(u => u.DateCreated));
        }

        [HttpPost]
        public async Task<IActionResult> ManageUsersRoles(ManageUserEntry manageUserEntry)
        {
            if ((int)HttpContext.Session.GetObjectFromJson<TypeOfUser>("TypeOfUser") > 2 || (int)HttpContext.Session.GetObjectFromJson<TypeOfUser>("TypeOfUser") == 0)
                return RedirectToAction("Index", "Manage");
            SetVariables();

            var user = await _userManager.GetUserByEmailAsync(manageUserEntry.Email);
            if (user != null)
            {
                user = UpdateUserType(user, manageUserEntry);
                _context.Update(user);
                await _context.SaveChangesAsync();
                ViewData["Success"] = "Success";
            }
            else
                ViewData["Success"] = "Failure";
            return View();
        }

        private User UpdateUserType(User user, ManageUserEntry manageUserEntry)
        {
            var updatedUser = new User(
                user.FirstName,
                user.LastName,
                user.Email,
                user.Password,
                user.TypeOfUser = manageUserEntry.TypeOfUser,
                user.ValidationCode,
                user.IsEmailConfirmed = true,
                user.PictureURL = manageUserEntry.PictureURL?? user.PictureURL,
                new CustomId(new Guid(user.Id)),
                DateTime.Now
            );
            var id = new CustomId(new Guid(user.Id));
            return updatedUser;
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
