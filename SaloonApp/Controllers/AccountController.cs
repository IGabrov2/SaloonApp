using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SaloonApp.Common.Extensions;
using SaloonApp.Common.Helpers;
using SaloonApp.DB;
using SaloonApp.DTOs;
using SaloonApp.Extensions;
using SaloonApp.Notification.Domain;
using SaloonApp.NotificationService;
using SaloonApp.UserDom.Domain;
using SaloonApp.UserDom.Domain.Models;
using SaloonApp.UserService;

namespace SaloonApp.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private IUser _userManager = new UserManager();
        //private ILog _logger = Logger.GetInstance;
        private INotificationActor _notificationManager = new NotificationManager();
        private AppDbContext _ctx = new AppDbContext();

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public ActionResult ConfirmEmail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginEntry entry)
        {
            var IsSignedIn = HttpContext.Session.GetObjectFromJson<bool?>("IsSignedIn") ?? false;
            if (HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn"))
                return RedirectToAction("Login", "Account");

            ViewData["WrongLogin"] = null;
            if (entry.Email == null || entry.Password == null)
            {
                ViewData["WrongLogin"] = "Incorrect form!";
                return View();
            }

            try
            {
                var user = await _userManager.GetUserByEmailAsync(entry.Email);
                if (user != null)
                {
                    if (!user.IsEmailConfirmed)
                    {
                        ViewData["WrongLogin"] = "Email is not confirmed!";
                        return View(entry);
                    }
                    if (!HashUtils.VerifyPassword(entry.Password, user.Password))
                    {
                        /* Don't reveal which one is incorrect.  */
                        ViewData["WrongLogin"] = "Incorrect username or password!";
                        return View(entry);

                    }
                }

                SetUpVariables(user);
            }
            catch (Exception ex)
            {
                //await _logger.LogCustomExceptionAsync(ex, null);
                return RedirectToAction("Error", "Home");
            }
            return RedirectToAction("Index", "Manage");
        }

        private void SetUpVariables(User user)
        {
            HttpContext.Session.SetObjectAsJson<string>("UserId", user.Id);
            HttpContext.Session.SetObjectAsJson<string>("UserName", user.FullName);
            HttpContext.Session.SetObjectAsJson<string>("TypeOfUser", user.TypeOfUser.ToString());
            HttpContext.Session.SetObjectAsJson<bool?>("IsSignedIn", true);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterEntry entry)
        {
            //if (!entry.Email.Contains("@gmail.com"))
            //{
            //    ViewData["WrongRegister"] = "Only gmail.com accounts are allowed!";
            //    return View(entry);
            //}

            try
            {
                User user = await _userManager.GetUserByEmailAsync(entry.Email);
                if (user != null)
                {
                    ViewData["WrongRegister"] = "Email already taken!";
                    return View(entry);
                }
                string password = HashUtils.CreateHashCode(entry.Password);
                string validationCode = HashUtils.CreateReferralCode();
                User newUser = new User(entry.FirstName, entry.LastName, entry.Email, password, TypeOfUser.Customer, validationCode);

                await _userManager.RegisterAsync(newUser);
                await _notificationManager.CreateConfirmationEmailAsync(newUser);
            }
            catch (Exception ex)
            {
                //await _logger.LogCustomExceptionAsync(ex, null);
                return RedirectToAction("Error", "Home");
            }

            return View("Welcome");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> ValidateEmail(string userId, string validationCode)
        {
            if (userId == null || validationCode == null)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            try
            {
                User user = await _userManager.GetUserByIdAsync(userId);
                if (user == null || validationCode != user.ValidationCode)
                {
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }

                user = _userManager.UpdateUserEmailConfirmationHelper(user);
                _ctx.Update(user);
                await _ctx.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                //await _logger.LogCustomExceptionAsync(ex, null);
                return RedirectToAction("Error", "Home");
            }
            return View("ConfirmEmail");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            HttpContext.Session.SetObjectAsJson<string>("UserId", null);
            HttpContext.Session.SetObjectAsJson<string>("UserName", null);
            HttpContext.Session.SetObjectAsJson<TypeOfUser>("TypeOfUser", TypeOfUser.NotLoggedIn);
            HttpContext.Session.SetObjectAsJson<bool>("IsSignedIn", false);
            return RedirectToAction("Index", "Home");
        }
    }
}
