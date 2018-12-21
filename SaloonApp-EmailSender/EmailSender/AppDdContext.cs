using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailSender
{
    public class AppDbContext : DbContext
    {
        private string connection;

        public AppDbContext()
        {
            this.connection = DBConnections.GetAppHarborConnection();
        }

        public DbSet<EmailTempl> Emails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
