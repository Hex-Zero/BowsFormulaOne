﻿// <auto-generated />
using System;
using BowsFormulaOneAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BowsFormulaOne.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211007093546_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("BowsFormulaOneAPI.Data.Models.CardDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Balance")
                        .HasColumnType("money");

                    b.Property<DateTime>("CardLockedTill")
                        .HasColumnType("TEXT");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<sbyte>("PinAttempts")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserDtoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserDtoId");

                    b.ToTable("CardDto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Balance = 10m,
                            CardLockedTill = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(6302),
                            CardNumber = "r7jTG8dqBy5wGO4L",
                            CreatedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(6291),
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(6299),
                            PinAttempts = (sbyte)0,
                            PinCode = "1000",
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Balance = 20m,
                            CardLockedTill = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(7132),
                            CardNumber = "r7jTG83qBy5wGO4L",
                            CreatedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(7120),
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(7130),
                            PinAttempts = (sbyte)0,
                            PinCode = "1200",
                            UserDtoId = 2
                        });
                });

            modelBuilder.Entity("BowsFormulaOneAPI.Data.Models.EmailDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserDtoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserDtoId");

                    b.ToTable("Emails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmailAddress = "Hex@live.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(5037),
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 3,
                            EmailAddress = "Hexzero@gmail.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(5558),
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 4,
                            EmailAddress = "Hex@live.co.uk",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(5566),
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 2,
                            EmailAddress = "Alex@gmail.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(5569),
                            UserDtoId = 2
                        });
                });

            modelBuilder.Entity("BowsFormulaOneAPI.Data.Models.PhoneNumberDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserDtoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserDtoId");

                    b.ToTable("PhoneNumbers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(3859),
                            PhoneNumber = "07667587200",
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(4387),
                            PhoneNumber = "07667986200",
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(4395),
                            PhoneNumber = "07667987206",
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(4398),
                            PhoneNumber = "07662987201",
                            UserDtoId = 2
                        });
                });

            modelBuilder.Entity("BowsFormulaOneAPI.Data.Models.UserDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 10, 7, 10, 35, 45, 725, DateTimeKind.Local).AddTicks(8327),
                            EmployeeNumber = "Es553",
                            FirstName = "Maxwell",
                            IsDeleted = false,
                            LastName = "Archer",
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 727, DateTimeKind.Local).AddTicks(5256)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 10, 7, 10, 35, 45, 727, DateTimeKind.Local).AddTicks(6170),
                            EmployeeNumber = "r7jTG8dqBy5wGO4L",
                            FirstName = "Alexandra",
                            IsDeleted = false,
                            LastName = "Archer",
                            ModifiedDate = new DateTime(2021, 10, 7, 10, 35, 45, 727, DateTimeKind.Local).AddTicks(6179)
                        });
                });

            modelBuilder.Entity("BowsFormulaOneAPI.Data.Models.CardDto", b =>
                {
                    b.HasOne("BowsFormulaOneAPI.Data.Models.UserDto", null)
                        .WithMany("Cards")
                        .HasForeignKey("UserDtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BowsFormulaOneAPI.Data.Models.EmailDto", b =>
                {
                    b.HasOne("BowsFormulaOneAPI.Data.Models.UserDto", null)
                        .WithMany("Emails")
                        .HasForeignKey("UserDtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BowsFormulaOneAPI.Data.Models.PhoneNumberDto", b =>
                {
                    b.HasOne("BowsFormulaOneAPI.Data.Models.UserDto", null)
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("UserDtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BowsFormulaOneAPI.Data.Models.UserDto", b =>
                {
                    b.Navigation("Cards");

                    b.Navigation("Emails");

                    b.Navigation("PhoneNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}