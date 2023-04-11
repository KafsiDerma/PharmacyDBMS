﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacyDBMS.Data;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    [DbContext(typeof(PharmacyContext))]
    [Migration("20230411143725_twelve")]
    partial class twelve
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("PharmacyDBMS.Data.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cashierid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Receipt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("healthcardnum")
                        .HasColumnType("INTEGER");

                    b.Property<float>("total_price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("PharmacyDBMS.Data.Dispenses", b =>
                {
                    b.Property<int>("CartID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductID")
                        .HasColumnType("TEXT");

                    b.Property<int>("PharmacistID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CartID", "ProductID", "PharmacistID");

                    b.ToTable("Dispenses");
                });

            modelBuilder.Entity("PharmacyDBMS.Data.Doctor", b =>
                {
                    b.Property<int>("Medical_License")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("phoneNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Medical_License");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("PharmacyDBMS.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Salary")
                        .HasColumnType("REAL");

                    b.Property<string>("supervisor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employee", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 3440,
                            HashedPassword = "$2a$10$/66E8MhHXuo2v3fO68yJQeq2n7VaAyiRfdhlQU3xbgrZ3tU.Hyg16",
                            Name = "admin",
                            PhoneNumber = "",
                            Position = 5,
                            Salary = 0f
                        });
                });

            modelBuilder.Entity("PharmacyDBMS.Data.InsuranceAgency", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Phone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("InsuranceAgencies");
                });

            modelBuilder.Entity("PharmacyDBMS.Data.Patient", b =>
                {
                    b.Property<int>("HealthCardNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PatientFullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("HealthCardNum");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PharmacyDBMS.Data.Prescription", b =>
                {
                    b.Property<int>("prescriptionNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoctorMLNum")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("PatientID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.HasKey("prescriptionNum");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("PharmacyDBMS.Data.Product", b =>
                {
                    b.Property<int>("productID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("discount")
                        .HasColumnType("REAL");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("price")
                        .HasColumnType("REAL");

                    b.Property<int>("stockAmount")
                        .HasColumnType("INTEGER");

                    b.HasKey("productID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PharmacyDBMS.Data.Supplier", b =>
                {
                    b.Property<int>("BusinessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("phonenumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BusinessID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("PharmacyDBMS.Data.prescription_only", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Guide")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Scientific_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Prescriptions_only");
                });
#pragma warning restore 612, 618
        }
    }
}
