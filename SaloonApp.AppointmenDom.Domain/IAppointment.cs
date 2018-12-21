using SaloonApp.AppointmentDom.Domain.Models;
using SaloonApp.UDF.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SaloonApp.AppointmentDom.Domain
{
    public interface IAppointment
    {
        Task CreateAppointmentUDF(AppointmentProcedureUDF appointmentProcedureUDF);
        Task CreateAppointment(Appointment appointment);
        Task DeleteAppointment(int IdAppointment);
        Task UpdateAppointment(Appointment appointment);
        Task<List<Appointment>> GetAllAppointments();
        Task<Appointment> GetAppointmentById(int id);
        Task<List<Appointment>> GetAllAppointmentsByUserId(string name);
        Task<List<Appointment>> GetAllAppointmentsByDate(DateTime date);
        Task<ProceduresSettings> GetProceduresSettings(bool IsMale);
    }
}
