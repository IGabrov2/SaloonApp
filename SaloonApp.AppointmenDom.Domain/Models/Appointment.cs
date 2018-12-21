using SaloonApp.UDF.Domain;
using SaloonApp.UserDom.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaloonApp.AppointmentDom.Domain.Models
{
    public class Appointment
    {
        [Key]
        public int IdAppointment { get; set; }
        public virtual User HairDresser { get; private set; }
        public virtual AppointmentProcedureUDF AppointmentUDF { get; private set; }
        public string IdHairDresser { get; set; }
        public int IdAppointmentUDF { get; set; }
        public DateTime AppointmentHour { get; set; }
        public string AppointmentDrutation { get; set; }
        public decimal BillingAmmount { get; set; }
        [NotMapped]
        public string HairDresserName { get; set; }
        [NotMapped]
        public string AppointmentUDFStr { get; set; }

        public Appointment() {}
        public Appointment(User HairDresser, AppointmentProcedureUDF AppointmentUDF, DateTime AppointmentHour)
        {
            
        }
    }
}
