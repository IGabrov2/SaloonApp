using SaloonApp.UserDom.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaloonApp.DTOs
{
    public class ManageUserEntry
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public TypeOfUser TypeOfUser { get; set; }

        public string PictureURL { get; set; }

    }
}
