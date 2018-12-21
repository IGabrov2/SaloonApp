using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace EmailSender
{
    class Program
    {
        static void Main()
        {
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=964f8e95-1103-4f33-951c-a86d00b4391b.sqlserver.sequelizer.com;Initial Catalog = db964f8e9511034f33951ca86d00b4391b; User ID = iazudehemvwiyvon; Password = gwtTmWZbawgDKXCiT7QmtwQ7JSCQMiASHDvviu2Dj3VSdUGNvTHbhvmSNvjBsiwY;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            while (true)
            {
                cmd.CommandText = "select * from emails where [Status] = 0";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                reader = cmd.ExecuteReader();
                var emails = new List<EmailTempl>();
                int exc = 0;

                while (reader.Read())
                {
                    int Id = int.Parse(reader["Id"].ToString());
                    string Email = reader["Email"].ToString();
                    string Message = reader["Message"].ToString();
                    EmailStatus Status = (EmailStatus)int.Parse(reader["Status"].ToString());
                    string Subject = reader["Subject"].ToString();

                    var newEmail = new EmailTempl(Email, Subject, Message, Status,Id);

                    emails.Add(newEmail);
                    
                }
                sqlConnection1.Close();

                foreach (var email in emails)
                {
                    SendEmailAsync(email, cmd, sqlConnection1);
                }

                Thread.Sleep(10000);
            }
        }

        private static void SendEmailAsync(EmailTempl emailTempl, SqlCommand cmd, SqlConnection sqlConnection1)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("gabrov.pv@gmail.com", "ivan9610264441")
                };

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("whoever@me.com")
                };
                mailMessage.To.Add(emailTempl.Email);
                mailMessage.Body = emailTempl.Message;
                mailMessage.IsBodyHtml = true;
                mailMessage.Subject = emailTempl.Subject;
                client.EnableSsl = true;
                client.Send(mailMessage);

                cmd.CommandText = "update emails set [status] = 1  where Id = " + emailTempl.Id;
                cmd.CommandType = CommandType.Text;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                cmd.CommandText = "update emails set ErrorWhileSending = " + ex.Message +" and [status] = 2" + " where Id = " + emailTempl.Id;
                cmd.CommandType = CommandType.Text;
                //sqlConnection1.Open();
                //cmd.ExecuteNonQuery();
                //sqlConnection1.Close();
                throw new ApplicationException($"Unable to load : '{ex.Message}'.");
            }
        }
    }
}
