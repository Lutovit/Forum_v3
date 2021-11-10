﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Entities;

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211008195800_adding_avatars")]
    partial class adding_avatars
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                            ConcurrencyStamp = "72d0a639-4d1a-46c7-bbef-edf7dc9f3e7e",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ad376a8f-9zxb-4bb9-9fca-30b01540f173",
                            ConcurrencyStamp = "d45c85c1-674c-499d-868a-88d2f6479b85",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            RoleId = "ad376a8f-9eab-4bb9-9fca-30b01540f445"
                        },
                        new
                        {
                            UserId = "a17be9c0-aa65-4af8-bd17-00bd9443e575",
                            RoleId = "ad376a8f-9zxb-4bb9-9fca-30b01540f173"
                        },
                        new
                        {
                            UserId = "a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                            RoleId = "ad376a8f-9zxb-4bb9-9fca-30b01540f173"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Repository.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("isBanned")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelited")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            AccessFailedCount = 0,
                            ClientName = "Maxim Malakhov",
                            CompanyName = "MaxFunnyApps",
                            ConcurrencyStamp = "ca4c010d-2486-4dc5-b3af-0fcf033601d8",
                            DateOfRegistration = new DateTime(2021, 10, 8, 22, 57, 57, 977, DateTimeKind.Local).AddTicks(9228),
                            Email = "pilot_mig@bk.ru",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "PILOT_MIG@BK.RU",
                            NormalizedUserName = "PILOT_MIG@BK.RU",
                            PasswordHash = "AQAAAAEAACcQAAAAENvaszQsfLf9DL7GfcgzhopjLiiXtzyYC1O+q8P/8ky40OWGP9WAsIZAR0208JL1GA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "pilot_mig@bk.ru",
                            isBanned = false,
                            isDelited = false
                        },
                        new
                        {
                            Id = "a17be9c0-aa65-4af8-bd17-00bd9443e575",
                            AccessFailedCount = 0,
                            ClientName = "Dima Ivanov",
                            CompanyName = "Dima Constractions",
                            ConcurrencyStamp = "a9723af9-c847-4340-97ea-11c9c0f6b0ed",
                            DateOfRegistration = new DateTime(2021, 10, 8, 22, 57, 57, 999, DateTimeKind.Local).AddTicks(7726),
                            Email = "diman@bk.ru",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "DIMAN@BK.RU",
                            NormalizedUserName = "DIMAN@BK.RU",
                            PasswordHash = "AQAAAAEAACcQAAAAEAnfx2pLa9aTD2kD1Fw3wd8ZzZBhemUR6Qmj7Y6CRImFVF7NxoWXKJusq5ACOjjbLg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "diman@bk.ru",
                            isBanned = true,
                            isDelited = false
                        },
                        new
                        {
                            Id = "a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                            AccessFailedCount = 0,
                            ClientName = "Sergei Butovo",
                            CompanyName = "Sergio Vine Company",
                            ConcurrencyStamp = "4d0e807d-9ede-4d8b-810f-3f79723c656e",
                            DateOfRegistration = new DateTime(2021, 10, 8, 22, 57, 58, 21, DateTimeKind.Local).AddTicks(4916),
                            Email = "sergio@bk.ru",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SERGIO@BK.RU",
                            NormalizedUserName = "SERGIO@BK.RU",
                            PasswordHash = "AQAAAAEAACcQAAAAELqdayseOoTKIHdVwwCsdG4X0wnaUhzmLK0c/PM1XJg2f4mJjVtR4gwViHa1pfSFFg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "sergio@bk.ru",
                            isBanned = false,
                            isDelited = false
                        });
                });

            modelBuilder.Entity("Repository.Entities.BanEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BanEmails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "diman@bk.ru"
                        });
                });

            modelBuilder.Entity("Repository.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfLastEdit")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDelited")
                        .HasColumnType("bit");

                    b.Property<bool>("isEdited")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("TopicId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(6182),
                            DateOfLastEdit = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(6199),
                            Text = "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.",
                            TopicId = 1,
                            UserName = "pilot_mig@bk.ru",
                            isDelited = false,
                            isEdited = false
                        },
                        new
                        {
                            Id = 2,
                            ApplicationUserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(7839),
                            DateOfLastEdit = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(7842),
                            Text = "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.",
                            TopicId = 1,
                            UserName = "pilot_mig@bk.ru",
                            isDelited = false,
                            isEdited = false
                        },
                        new
                        {
                            Id = 3,
                            ApplicationUserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(7854),
                            DateOfLastEdit = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(7857),
                            Text = "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.",
                            TopicId = 1,
                            UserName = "pilot_mig@bk.ru",
                            isDelited = false,
                            isEdited = false
                        },
                        new
                        {
                            Id = 4,
                            ApplicationUserId = "a17be9c0-aa65-4af8-bd17-00bd9443e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8450),
                            DateOfLastEdit = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8453),
                            Text = "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.",
                            TopicId = 2,
                            UserName = "diman@bk.ru",
                            isDelited = false,
                            isEdited = false
                        },
                        new
                        {
                            Id = 5,
                            ApplicationUserId = "a17be9c0-aa65-4af8-bd17-00bd9443e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8465),
                            DateOfLastEdit = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8469),
                            Text = "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.",
                            TopicId = 2,
                            UserName = "diman@bk.ru",
                            isDelited = false,
                            isEdited = false
                        },
                        new
                        {
                            Id = 6,
                            ApplicationUserId = "a17be9c0-aa65-4af8-bd17-00bd9443e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8480),
                            DateOfLastEdit = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8483),
                            Text = "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.",
                            TopicId = 2,
                            UserName = "diman@bk.ru",
                            isDelited = false,
                            isEdited = false
                        },
                        new
                        {
                            Id = 7,
                            ApplicationUserId = "a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8585),
                            DateOfLastEdit = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8588),
                            Text = "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.",
                            TopicId = 3,
                            UserName = "sergio@bk.ru",
                            isDelited = false,
                            isEdited = false
                        },
                        new
                        {
                            Id = 8,
                            ApplicationUserId = "a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8600),
                            DateOfLastEdit = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8603),
                            Text = "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.",
                            TopicId = 3,
                            UserName = "sergio@bk.ru",
                            isDelited = false,
                            isEdited = false
                        },
                        new
                        {
                            Id = 9,
                            ApplicationUserId = "a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8614),
                            DateOfLastEdit = new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8617),
                            Text = "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.",
                            TopicId = 3,
                            UserName = "sergio@bk.ru",
                            isDelited = false,
                            isEdited = false
                        });
                });

            modelBuilder.Entity("Repository.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("TopicDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDelited")
                        .HasColumnType("bit");

                    b.Property<bool>("isEdited")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 22, DateTimeKind.Local).AddTicks(4657),
                            TopicDescription = "Discussing star ships, their engines and something like this.",
                            TopicName = "Star ships, interstellars comunications, gelium atomic engines.",
                            isDelited = false,
                            isEdited = false
                        },
                        new
                        {
                            Id = 2,
                            ApplicationUserId = "a17be9c0-aa65-4af8-bd17-00bd9443e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 22, DateTimeKind.Local).AddTicks(7125),
                            TopicDescription = "Discussing we spend time during interstellar voyages.",
                            TopicName = "Vine and sigaretes while you are in deep space.",
                            isDelited = false,
                            isEdited = false
                        },
                        new
                        {
                            Id = 3,
                            ApplicationUserId = "a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                            Date = new DateTime(2021, 10, 8, 22, 57, 58, 22, DateTimeKind.Local).AddTicks(7137),
                            TopicDescription = "How we do sport, while we are in space.",
                            TopicName = "Sports in space.",
                            isDelited = false,
                            isEdited = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Repository.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Repository.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Repository.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Repository.Entities.Message", b =>
                {
                    b.HasOne("Repository.Entities.ApplicationUser", "User")
                        .WithMany("UserMessages")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Repository.Entities.Topic", "Topic")
                        .WithMany("TopicMessages")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Entities.Topic", b =>
                {
                    b.HasOne("Repository.Entities.ApplicationUser", "User")
                        .WithMany("UserTopics")
                        .HasForeignKey("ApplicationUserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Entities.ApplicationUser", b =>
                {
                    b.Navigation("UserMessages");

                    b.Navigation("UserTopics");
                });

            modelBuilder.Entity("Repository.Entities.Topic", b =>
                {
                    b.Navigation("TopicMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
