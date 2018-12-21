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
    [Migration("20180303100625_InitialCreate")]
    partial class InitialCreate
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

                    b.Property<DateTime>("AppointmentHour");

                    b.Property<string>("HairDresserId");

                    b.Property<int?>("ProceduresIdProcedure");

                    b.HasKey("IdAppointment");

                    b.HasIndex("HairDresserId");

                    b.HasIndex("ProceduresIdProcedure");

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
                    b.HasOne("SaloonApp.UserDom.Domain.Models.User", "HairDresser")
                        .WithMany()
                        .HasForeignKey("HairDresserId");

                    b.HasOne("SaloonApp.AppointmentDom.Domain.Models.Procedures", "Procedures")
                        .WithMany()
                        .HasForeignKey("ProceduresIdProcedure");
                });
#pragma warning restore 612, 618
        }
    }
}
