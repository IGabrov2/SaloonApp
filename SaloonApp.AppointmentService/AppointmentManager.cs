using Microsoft.EntityFrameworkCore;
using SaloonApp.AppointmentDom.Domain;
using SaloonApp.AppointmentDom.Domain.Models;
using SaloonApp.DB;
using SaloonApp.UDF.Domain;
using SaloonApp.UserDom.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonApp.AppointmentService
{
    public class AppointmentManager : IAppointment
    {
        private readonly AppDbContext _ctx;

        public AppointmentManager()
        {
            this._ctx = new AppDbContext();
        }

        public async Task CreateAppointment(Appointment appointment)
        {
            await _ctx.Appointments.AddAsync(appointment);
            await _ctx.SaveChangesAsync();
        }

        public async Task UpdateAppointment(Appointment appointment)
        {
            var app = UpdateAppointmentHelper(appointment);
            await _ctx.Appointments.AddAsync(appointment);
            await _ctx.SaveChangesAsync();
        }

        public async Task DeleteAppointment(int IdAppointment)
        {
            var app = await GetAppointmentById(IdAppointment);
            _ctx.Appointments.Attach(app);
            _ctx.Appointments.Remove(app);
            _ctx.SaveChanges();
        }

        public async Task<List<Appointment>> GetAllAppointments()
        {
            //List<Appointment> appointments = await _ctx.Appointments.Include(p => p.Procedures).Include(p => p.HairDresser).ToListAsync();
            List<Appointment> appointments = await _ctx.Appointments.Include(p => p.HairDresser).Include(u => u.AppointmentUDF).ToListAsync();
            AdminUDF admUDFMale = await _ctx.ProcedireUDF.Where(u => u.Male == true).FirstOrDefaultAsync();
            AdminUDF admUDFFemale = await _ctx.ProcedireUDF.Where(u => u.Male == false).FirstOrDefaultAsync();

            Parallel.ForEach(appointments, app =>
           {
               app.AppointmentUDFStr = app.AppointmentUDF.Male ? app.AppointmentUDF.ToString(admUDFMale) : app.AppointmentUDF.ToString(admUDFFemale);
               app.HairDresserName = app.HairDresser.FullName;
           });
            //foreach (var app in appointments)
            //{
            //    app.ProceduresStr = app.Procedures.ToString();
            //    app.HairDresserName = app.HairDresser.FullName;
            //    app.Duration = app.Procedures.CalculateDuration();
            //    app.BillingAmmount = app.Procedures.CalculateAmount();
            //    app.AppointmentDrutation += string.Format("{0:HH:mm}", app.AppointmentHour) + "-";
            //    app.AppointmentHour = app.AppointmentHour.AddMinutes(app.Duration);
            //    app.AppointmentDrutation += string.Format("{0:HH:mm}", app.AppointmentHour);
            //}
            appointments.Sort((x, y) => string.Compare(x.AppointmentDrutation, y.AppointmentDrutation));
            return appointments;
        }

        public async Task<List<Appointment>> GetAllAppointmentsByUserId(string userID)
        {
            var appointments = await GetAllAppointments();
            return appointments.Where(a => a.HairDresser.Id == userID).ToList();
        }
        public async Task<List<Appointment>> GetAllAppointmentsByUserIdAndDate(string userID, DateTime date)
        {
            var appointments = await GetAllAppointments();
            appointments.Sort((x, y) => string.Compare(x.AppointmentHour.TimeOfDay.ToString(), y.AppointmentHour.TimeOfDay.ToString()));
            return appointments.Where(a => a.HairDresser.Id == userID && a.AppointmentHour.Date == date).ToList();
        }
        public async Task<Appointment> GetAppointmentById(int id)
        {
            var appointments = await GetAllAppointments();
            return appointments.FirstOrDefault(a => a.IdAppointment == id);
        }

        private Appointment UpdateAppointmentHelper(Appointment appointment)
        {
            var a = new Appointment
            {
                IdAppointment = appointment.IdAppointment,
                AppointmentHour = appointment.AppointmentHour
            };
            return a;
        }

        public async Task CreateAppointmentUDF(AppointmentProcedureUDF appointmentProcedureUDF)
        {
            await _ctx.AppointmentProcedureUDF.AddAsync(appointmentProcedureUDF);
            await _ctx.SaveChangesAsync();
        }

        public async Task<List<Appointment>> GetAllAppointmentsByDate(DateTime date)
        {
            var appointments = await GetAllAppointments();
            appointments.Sort((x, y) => string.Compare(x.AppointmentHour.ToString(), y.AppointmentHour.ToString()));
            return appointments.Where(a => a.AppointmentHour.Date == date).ToList();
        }

        public async Task<ProceduresSettings> GetProceduresSettings(bool IsMale)
        {
            var ProcedureSettings = await _ctx.ProceduresSettings.Where(p => p.Male == IsMale).ToListAsync();
            return ProcedureSettings.FirstOrDefault();
        }

    }
}
