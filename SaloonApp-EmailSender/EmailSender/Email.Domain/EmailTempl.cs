using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmailSender
{
    public class EmailTempl
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string ErrorWhileSending { get; set; }
        public string Message { get; set; }
        public EmailStatus Status { get; set; }
        public string Subject { get; set; }


        public EmailTempl(string email, string subject, string message)
        {
            this.Email = email;
            this.Subject = subject;
            this.Message = message;
            this.Status = EmailStatus.Pending;
        }
        public EmailTempl()
        {
        }
        public EmailTempl(string email, string subject, string message,EmailStatus status,  int id, string errorWhileSending=null )
        {
            this.Id = id;
            this.Email = email;
            this.Subject = subject;
            this.Message = message;
            this.Status = status;
            this.ErrorWhileSending = errorWhileSending;
        }

    }
}
