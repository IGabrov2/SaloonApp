using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SaloonApp.Email.Domain.Models
{
    public enum EmailStatus
    {
        [EnumMember(Value = "Pending")]
        Pending = 0,
        [EnumMember(Value = "Sent")]
        Sent = 1,
        [EnumMember(Value = "Error while sending")]
        Error = 2,

    }
}
