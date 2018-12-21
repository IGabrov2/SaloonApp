using SaloonApp.UserDom.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaloonApp.DTOs
{
    public class HomeEntry
    {
        public List<User> Users { get; set; }
        public List<List<string>> OpenHours { get; set; }
        public DateTime ForDate { get; set; }
    }
}
