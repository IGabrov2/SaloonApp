using SaloonApp.UDF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaloonApp.DTOs
{
    public class CreateAppointmentEntry
    {
        public AdminUDF UDFs { get; set; }
        public AppointmentProcedureUDF AppointmentUDFs { get; set; }
        public List<string> Hours { get; set; }
        public DateTime Date { get; set; }
        public string SelectedHour { get; set; }
        public bool Male { get; set; }
    }
}
