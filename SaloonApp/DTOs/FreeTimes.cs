using SaloonApp.AppointmentDom.Domain.Models;
using SaloonApp.UserDom.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaloonApp.DTOs
{
    public class FreeTimes
    {
        public List<string> OpenHours { get; set; }
        public DateTime ForDate { get; set; }
    }
}
