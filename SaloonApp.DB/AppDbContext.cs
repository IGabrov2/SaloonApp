using Microsoft.EntityFrameworkCore;


namespace SaloonApp.DB
{
    public class AppDbContext : DbContext
    {
        private string connection;

        public AppDbContext()
        {
            this.connection = DBConnections.GetAppHarborConnection();
        }

        public DbSet<SaloonApp.UserDom.Domain.Models.User> Users { get; set; }
        public DbSet<SaloonApp.Email.Domain.Models.EmailTempl> Emails { get; set; }
        public DbSet<SaloonApp.AppointmentDom.Domain.Models.Appointment> Appointments { get; set; }
        public DbSet<SaloonApp.AppointmentDom.Domain.Models.Procedures> Procedures { get; set; }
        public DbSet<SaloonApp.AppointmentDom.Domain.Models.ProceduresSettings> ProceduresSettings { get; set; }
        public DbSet<SaloonApp.UDF.Domain.AdminUDF> ProcedireUDF { get; set; }
        public DbSet<SaloonApp.UDF.Domain.AppointmentProcedureUDF> AppointmentProcedureUDF { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
