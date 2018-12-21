using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace EmailSender
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
