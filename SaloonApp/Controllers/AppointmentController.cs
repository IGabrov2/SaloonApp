using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SaloonApp.AppointmentDom.Domain.Models;
using SaloonApp.AppointmentService;
using SaloonApp.DB;
using SaloonApp.DTOs;
using SaloonApp.Extensions;
using SaloonApp.UDF;
using SaloonApp.UDF.Domain;
using SaloonApp.UserDom.Domain;
using SaloonApp.UserDom.Domain.Models;
using SaloonApp.UserService;

namespace SaloonApp.Controllers
{
    public class AppointmentController : Controller
    {
        private AppDbContext _context = new AppDbContext();
        private AppointmentManager _appointmantManager = new AppointmentManager();
        private UDFManager _UDFManager = new UDFManager();

        public AppointmentController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> AllAppointments(string date)
        {
            if (HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn") == false)
                return RedirectToAction("LogIn", "Account");

            SetVariables();

            var dateToShow = SetDate(date);
            ViewData["Date"] = dateToShow.Date.ToString().Replace('.','/').Replace("г/ 0:00:00","");
            ViewData["IsOne"] = false;
            var appointments = await _appointmantManager.GetAllAppointmentsByDate(dateToShow);
            return View("Apointments", appointments);
        }

        public async Task<IActionResult> Delete (int IdAppointment)
        {
            
            await _appointmantManager.DeleteAppointment(IdAppointment);

            var dateToShow = SetDate(null);
            var appointments = await _appointmantManager.GetAllAppointmentsByDate(dateToShow);
            return RedirectToAction("AllAppointments", "Appointment");
        }
 

        public async Task<IActionResult> EditAppointment(int Id)
        {
            if (HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn") == false)
                return RedirectToAction("LogIn", "Account");

            SetVariables();

            ViewData["IsOne"] = true;
            var appointments = new List<Appointment>();
            var appointment = await _appointmantManager.GetAppointmentById(Id);
            appointments.Add(appointment);
            return View("Apointments", appointments);

        }


        public async Task<IActionResult> SortBy(int sortColumn = 0)
        {
            if (HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn") == false)
                return RedirectToAction("LogIn", "Account");

            SetVariables();
            switch (sortColumn)
            {
                case 1:
                    {
                        ViewData["IsOne"] = false;
                        var appointments = await _appointmantManager.GetAllAppointments();
                        appointments.Sort((x, y) => string.Compare(x.IdAppointment.ToString(), y.IdAppointment.ToString()));
                        return View("Apointments", appointments);
                    }
                case 2:
                    {
                        ViewData["IsOne"] = false;
                        var appointments = await _appointmantManager.GetAllAppointments();
                        appointments.Sort((x, y) => string.Compare(x.HairDresserName, y.HairDresserName));
                        return View("Apointments", appointments);
                    }
                case 3:
                    {
                        ViewData["IsOne"] = false;
                        var appointments = await _appointmantManager.GetAllAppointments();
                        appointments.Sort((x, y) => string.Compare(x.AppointmentHour.ToString(), y.AppointmentHour.ToString()));
                        return View("Apointments", appointments);
                    }
                case 4:
                    {
                        ViewData["IsOne"] = false;
                        var appointments = await _appointmantManager.GetAllAppointments();
                        appointments.Sort((x, y) => string.Compare(x.BillingAmmount.ToString(), y.BillingAmmount.ToString()));
                        return View("Apointments", appointments);
                    }
                case 5:
                    {
                        ViewData["IsOne"] = false;
                        var appointments = await _appointmantManager.GetAllAppointments();
                        //appointments.Sort((x, y) => string.Compare(x.Procedures.ToString(), y.Procedures.ToString()));
                        return View("Apointments", appointments);
                    }
                default:
                    {
                        ViewData["IsOne"] = false;
                        var appointments = await _appointmantManager.GetAllAppointments();
                        return View("Apointments", appointments);
                    }
            }
        }
        public async Task<IActionResult> GroupByUser(string date, string userID)
        {
            if (HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn") == false)
                return RedirectToAction("LogIn", "Account");
            SetVariables();

            var dateToShow = SetDate(date);

            if (userID == null)
                userID = HttpContext.Session.GetObjectFromJson<string>("UserId");

            var appointments = await _appointmantManager.GetAllAppointmentsByUserIdAndDate(userID, dateToShow);
            return View("Apointments", appointments);
        }

        public async Task<IActionResult> ConstructAppointment(string Time, string ForDate, string UID)
        {
            if (HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn") == false)
                return RedirectToAction("LogIn", "Account");
            SetVariables();

            var date = ForDate.Split(' ')[0].Split('/').ToList();
            var forDate = new DateTime(int.Parse(date[2]), int.Parse(date[0]), int.Parse(date[1]));

            var times = Time.Split('-').Select(t => t.Trim()).ToList();
            var startTime = new DateTime(int.Parse(date[2]), int.Parse(date[0]), int.Parse(date[1]), int.Parse(times[0].Split(':')[0]), int.Parse(times[0].Split(':')[1]), 0);
            var endTIme = new DateTime(int.Parse(date[2]), int.Parse(date[0]), int.Parse(date[1]), int.Parse(times[1].Split(':')[0]), int.Parse(times[1].Split(':')[1]), 0);

            var obj = new CreateAppointmentEntry();
            obj.Hours = new List<string>();
            obj.Date = forDate.Date;
            obj.UDFs = _UDFManager.GetAdminUDFAsync(false).Result;
            HttpContext.Session.SetObjectAsJson<string>("ForUserID", UID ?? "");
            while (startTime != endTIme)
            {
                obj.Hours.Add(startTime.Hour.ToString() + ":" + startTime.Minute.ToString().PadLeft(2, '0'));
                startTime = startTime.AddMinutes(30);
            }

            return View("CreateAppointment", obj);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppointmentFromUser(CreateAppointmentEntry entry)
        {
            if (HttpContext.Session.GetObjectFromJson<bool>("IsSignedIn") == false)
                return RedirectToAction("LogIn", "Account");
            SetVariables();

            var appointmentUDF = new AppointmentProcedureUDF
            {
                AppointmentUDF1Checked = entry.AppointmentUDFs.AppointmentUDF1Checked,
                AppointmentUDF2Checked = entry.AppointmentUDFs.AppointmentUDF2Checked,
                AppointmentUDF3Checked = entry.AppointmentUDFs.AppointmentUDF3Checked,
                AppointmentUDF4Checked = entry.AppointmentUDFs.AppointmentUDF4Checked,
                AppointmentUDF5Checked = entry.AppointmentUDFs.AppointmentUDF5Checked,
                AppointmentUDF6Checked = entry.AppointmentUDFs.AppointmentUDF6Checked,
                AppointmentUDF7Checked = entry.AppointmentUDFs.AppointmentUDF7Checked,
                AppointmentUDF8Checked = entry.AppointmentUDFs.AppointmentUDF8Checked,
                AppointmentUDF9Checked = entry.AppointmentUDFs.AppointmentUDF9Checked,
                AppointmentUDF10Checked = entry.AppointmentUDFs.AppointmentUDF10Checked,
                Male = entry.Male
            };

            await _appointmantManager.CreateAppointmentUDF(appointmentUDF);

            var str = entry.SelectedHour.Substring(0, entry.SelectedHour.Length - 11).Split(' ');
            var hour = str[0].Split(':');
            var date = str[1].Split('/');
            var completeDate = new DateTime(int.Parse(date[2]), int.Parse(date[0]), int.Parse(date[1]), int.Parse(hour[0]), int.Parse(hour[1]), 0);
            var userManager = new UserManager();

            var hairDresser = new User();
            if (HttpContext.Session.GetObjectFromJson<string>("ForUserID") == "")
                hairDresser = await userManager.GetUserByIdAsync(HttpContext.Session.GetObjectFromJson<string>("UserId"));
            else
                hairDresser = await userManager.GetUserByIdAsync(HttpContext.Session.GetObjectFromJson<string>("ForUserID"));

            var admUDF = _UDFManager.GetAdminUDFAsync(entry.Male).Result;

            var appointment = new Appointment
            {
                AppointmentHour = completeDate,
                IdHairDresser = hairDresser.Id,
                IdAppointmentUDF = appointmentUDF.ID,
                BillingAmmount = _UDFManager.CalculateAmount(admUDF, appointmentUDF),
            };

            var duration = 30;
            appointment.AppointmentDrutation += string.Format("{0:HH:mm}", appointment.AppointmentHour) + "-";
            appointment.AppointmentHour = appointment.AppointmentHour.AddMinutes(duration);
            appointment.AppointmentDrutation += string.Format("{0:HH:mm}", appointment.AppointmentHour);
            appointment.AppointmentHour = appointment.AppointmentHour.AddMinutes(-duration);
            await _appointmantManager.CreateAppointment(appointment);

            HttpContext.Session.SetObjectAsJson<string>("ForUserID", "");
            return RedirectToAction("Index", "Home");
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
                List<string> nums = date.Split(' ')[0].Split('/').ToList();
                var year = int.Parse(nums[2]);
                var month = int.Parse(nums[0]);
                var day = int.Parse(nums[1]);
                dateToShow = new DateTime(year, month, day);
            }
            return dateToShow;
        }
    }
}