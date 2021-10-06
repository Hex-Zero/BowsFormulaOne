﻿// <auto-generated />
using System;
using BowsFormulaOneAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BowsFormulaOne.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("BowsFormulaOneAPI.Data.Models.CardDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CardLockedTill")
                        .HasColumnType("TEXT");

                    b.Property<string>("CardNumber")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<sbyte>("PinAttempts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PinCode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserDtoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserDtoId");

                    b.ToTable("CardDto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardLockedTill = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3097),
                            CardNumber = "r7jTG8dqBy5wGO4L",
                            CreatedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3085),
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3094),
                            PinAttempts = (sbyte)0,
                            PinCode = 1000,
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 2,
                            CardLockedTill = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3702),
                            CardNumber = "r7jTG83qBy5wGO4L",
                            CreatedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3692),
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3700),
                            PinAttempts = (sbyte)0,
                            PinCode = 1200,
                            UserDtoId = 2
                        });
                });

            modelBuilder.Entity("BowsFormulaOneAPI.Data.Models.EmailDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
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
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(1842),
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 3,
                            EmailAddress = "Hexzero@gmail.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(2413),
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 4,
                            EmailAddress = "Hex@live.co.uk",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(2421),
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 2,
                            EmailAddress = "Alex@gmail.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(2424),
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
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(684),
                            PhoneNumber = "07667587200",
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(1214),
                            PhoneNumber = "07667986200",
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(1222),
                            PhoneNumber = "07667987206",
                            UserDtoId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(1225),
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
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 10, 6, 19, 29, 6, 895, DateTimeKind.Local).AddTicks(5141),
                            EmployeeNumber = "Es553",
                            FirstName = "Maxwell",
                            IsDeleted = false,
                            LastName = "Archer",
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 897, DateTimeKind.Local).AddTicks(2271)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 10, 6, 19, 29, 6, 897, DateTimeKind.Local).AddTicks(3174),
                            EmployeeNumber = "r7jTG8dqBy5wGO4L",
                            FirstName = "Alexandra",
                            IsDeleted = false,
                            LastName = "Archer",
                            ModifiedDate = new DateTime(2021, 10, 6, 19, 29, 6, 897, DateTimeKind.Local).AddTicks(3184)
                        });
                });

            modelBuilder.Entity("BowsFormulaOneAPI.Data.Models.CardDto", b =>
                {
                    b.HasOne("BowsFormulaOneAPI.Data.Models.UserDto", "CardUser")
                        .WithMany("Cards")
                        .HasForeignKey("UserDtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardUser");
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
