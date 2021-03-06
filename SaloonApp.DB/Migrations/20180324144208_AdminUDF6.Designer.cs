﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SaloonApp.DB;
using SaloonApp.Email.Domain.Models;
using SaloonApp.UserDom.Domain;
using System;

namespace SaloonApp.DB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180324144208_AdminUDF6")]
    partial class AdminUDF6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SaloonApp.AppointmentDom.Domain.Models.Appointment", b =>
                {
                    b.Property<int>("IdAppointment")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppointmentDrutation");

                    b.Property<DateTime>("AppointmentHour");

                    b.Property<int?>("AppointmentUDFID");

                    b.Property<decimal>("BillingAmmount");

                    b.Property<string>("HairDresserId");

                    b.Property<int>("IdAppointmentUDF");

                    b.Property<string>("IdHairDresser");

                    b.HasKey("IdAppointment");

                    b.HasIndex("AppointmentUDFID");

                    b.HasIndex("HairDresserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("SaloonApp.AppointmentDom.Domain.Models.Procedures", b =>
                {
                    b.Property<int>("IdProcedure")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Blowing");

                    b.Property<bool>("Dying");

                    b.Property<bool>("HairCut");

                    b.Property<bool>("Hairstyle");

                    b.Property<bool>("MakeUp");

                    b.Property<bool>("Male");

                    b.Property<bool>("Manicure");

                    b.Property<bool>("PartialDying");

                    b.Property<bool>("Pedicure");

                    b.Property<bool>("Washing");

                    b.HasKey("IdProcedure");

                    b.ToTable("Procedures");
                });

            modelBuilder.Entity("SaloonApp.AppointmentDom.Domain.Models.ProceduresSettings", b =>
                {
                    b.Property<int>("IdProceduresSettings")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AmountForBlowing");

                    b.Property<int>("AmountForDying");

                    b.Property<int>("AmountForHairCut");

                    b.Property<int>("AmountForHairstyle");

                    b.Property<int>("AmountForMakeUp");

                    b.Property<int>("AmountForManicure");

                    b.Property<int>("AmountForPartialDying");

                    b.Property<int>("AmountForPedicure");

                    b.Property<int>("AmountForWashing");

                    b.Property<int>("DurationForBlowing");

                    b.Property<int>("DurationForDying");

                    b.Property<int>("DurationForHairCut");

                    b.Property<int>("DurationForHairstyle");

                    b.Property<int>("DurationForMakeUp");

                    b.Property<int>("DurationForManicure");

                    b.Property<int>("DurationForPartialDying");

                    b.Property<int>("DurationForPedicure");

                    b.Property<int>("DurationForWashing");

                    b.Property<bool>("Male");

                    b.HasKey("IdProceduresSettings");

                    b.ToTable("ProceduresSettings");
                });

            modelBuilder.Entity("SaloonApp.Email.Domain.Models.EmailTempl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("ErrorWhileSending");

                    b.Property<string>("Message");

                    b.Property<int>("Status");

                    b.Property<string>("Subject");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("SaloonApp.UDF.Domain.AdminUDF", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AppointmentUDFChek10Amount");

                    b.Property<bool>("AppointmentUDFChek10Enabled");

                    b.Property<string>("AppointmentUDFChek10Label");

                    b.Property<int>("AppointmentUDFChek10Time");

                    b.Property<int>("AppointmentUDFChek1Amount");

                    b.Property<bool>("AppointmentUDFChek1Enabled");

                    b.Property<string>("AppointmentUDFChek1Label");

                    b.Property<int>("AppointmentUDFChek1Time");

                    b.Property<int>("AppointmentUDFChek2Amount");

                    b.Property<bool>("AppointmentUDFChek2Enabled");

                    b.Property<string>("AppointmentUDFChek2Label");

                    b.Property<int>("AppointmentUDFChek2Time");

                    b.Property<int>("AppointmentUDFChek3Amount");

                    b.Property<bool>("AppointmentUDFChek3Enabled");

                    b.Property<string>("AppointmentUDFChek3Label");

                    b.Property<int>("AppointmentUDFChek3Time");

                    b.Property<int>("AppointmentUDFChek4Amount");

                    b.Property<bool>("AppointmentUDFChek4Enabled");

                    b.Property<string>("AppointmentUDFChek4Label");

                    b.Property<int>("AppointmentUDFChek4Time");

                    b.Property<int>("AppointmentUDFChek5Amount");

                    b.Property<bool>("AppointmentUDFChek5Enabled");

                    b.Property<string>("AppointmentUDFChek5Label");

                    b.Property<int>("AppointmentUDFChek5Time");

                    b.Property<int>("AppointmentUDFChek6Amount");

                    b.Property<bool>("AppointmentUDFChek6Enabled");

                    b.Property<string>("AppointmentUDFChek6Label");

                    b.Property<int>("AppointmentUDFChek6Time");

                    b.Property<int>("AppointmentUDFChek7Amount");

                    b.Property<bool>("AppointmentUDFChek7Enabled");

                    b.Property<string>("AppointmentUDFChek7Label");

                    b.Property<int>("AppointmentUDFChek7Time");

                    b.Property<int>("AppointmentUDFChek8Amount");

                    b.Property<bool>("AppointmentUDFChek8Enabled");

                    b.Property<string>("AppointmentUDFChek8Label");

                    b.Property<int>("AppointmentUDFChek8Time");

                    b.Property<int>("AppointmentUDFChek9Amount");

                    b.Property<bool>("AppointmentUDFChek9Enabled");

                    b.Property<string>("AppointmentUDFChek9Label");

                    b.Property<int>("AppointmentUDFChek9Time");

                    b.HasKey("ID");

                    b.ToTable("ProcedireUDF");
                });

            modelBuilder.Entity("SaloonApp.UDF.Domain.AppointmentProcedureUDF", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AppointmentUDF10Amount");

                    b.Property<bool>("AppointmentUDF10Checked");

                    b.Property<int>("AppointmentUDF10Time");

                    b.Property<int>("AppointmentUDF1Amount");

                    b.Property<bool>("AppointmentUDF1Checked");

                    b.Property<int>("AppointmentUDF1Time");

                    b.Property<int>("AppointmentUDF2Amount");

                    b.Property<bool>("AppointmentUDF2Checked");

                    b.Property<int>("AppointmentUDF2Time");

                    b.Property<int>("AppointmentUDF3Amount");

                    b.Property<bool>("AppointmentUDF3Checked");

                    b.Property<int>("AppointmentUDF3Time");

                    b.Property<int>("AppointmentUDF4Amount");

                    b.Property<bool>("AppointmentUDF4Checked");

                    b.Property<int>("AppointmentUDF4Time");

                    b.Property<int>("AppointmentUDF5Amount");

                    b.Property<bool>("AppointmentUDF5Checked");

                    b.Property<int>("AppointmentUDF5Time");

                    b.Property<int>("AppointmentUDF6Amount");

                    b.Property<bool>("AppointmentUDF6Checked");

                    b.Property<int>("AppointmentUDF6Time");

                    b.Property<int>("AppointmentUDF7Amount");

                    b.Property<bool>("AppointmentUDF7Checked");

                    b.Property<int>("AppointmentUDF7Time");

                    b.Property<int>("AppointmentUDF8Amount");

                    b.Property<bool>("AppointmentUDF8Checked");

                    b.Property<int>("AppointmentUDF8Time");

                    b.Property<int>("AppointmentUDF9Amount");

                    b.Property<bool>("AppointmentUDF9Checked");

                    b.Property<int>("AppointmentUDF9Time");

                    b.HasKey("ID");

                    b.ToTable("AppointmentProcedureUDF");
                });

            modelBuilder.Entity("SaloonApp.UserDom.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsEmailConfirmed");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<int>("TypeOfUser");

                    b.Property<string>("ValidationCode");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SaloonApp.AppointmentDom.Domain.Models.Appointment", b =>
                {
                    b.HasOne("SaloonApp.UDF.Domain.AppointmentProcedureUDF", "AppointmentUDF")
                        .WithMany()
                        .HasForeignKey("AppointmentUDFID");

                    b.HasOne("SaloonApp.UserDom.Domain.Models.User", "HairDresser")
                        .WithMany()
                        .HasForeignKey("HairDresserId");
                });
#pragma warning restore 612, 618
        }
    }
}
