﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string ClientName { set; get; }

        public string CompanyName { set; get; }

        public DateTime DateOfRegistration { set; get; }

        public bool isBanned { set; get; }

        public bool isDelited { set; get; }


        public ICollection<Message> UserMessages { set; get; }

        public ICollection<Topic> UserTopics { set; get; }


        public ApplicationUser()
        {
            UserMessages = new List<Message>();
            UserTopics = new List<Topic>();

            DateOfRegistration = DateTime.Now;

            isBanned = false;
            isDelited = false;
        }  
    }



    public class Message
    {
        public int Id { set; get; }

        public DateTime Date { set; get; }

        public bool isEdited { set; get; }

        public bool isDelited { set; get; }

        public DateTime DateOfLastEdit { set; get; }

        public string Text { set; get; }



        public string ApplicationUserId { set; get; }
        public ApplicationUser User { set; get; }
        public string UserName { set; get; }



        public int TopicId { set; get; }
        public Topic Topic { set; get; }



        public Message()
        {
            Date = DateTime.Now;
            DateOfLastEdit = DateTime.Now;
            isEdited = false;
            isDelited = false;
        }
    }




    public class Topic
    {
        public int Id { set; get; }

        public DateTime Date { set; get; }

        public string TopicName { set; get; }

        public string TopicDescription { set; get; }

        public bool isEdited { set; get; }

        public bool isDelited { set; get; }



        public string ApplicationUserId { set; get; }
        public ApplicationUser User { set; get; }


        public ICollection<Message> TopicMessages { set; get; }


        public Topic()
        {
            Date = DateTime.Now;  
            isEdited = false;
            isDelited = false;

            TopicMessages = new List<Message>();
        }
    }




    public class BanEmail
    {
        public int Id { set; get; }
        public string Email { set; get; }
    }





    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<BanEmail> BanEmails { set; get; }

        public DbSet<Topic> Topics { set; get; }

        public DbSet<Message> Messages { set; get; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();
           //Database.EnsureCreated();
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BanEmail>().HasData( new BanEmail[]
            {
                new BanEmail{ Id=1, Email="diman@bk.ru"}
             });



            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole[]
            {                
                new IdentityRole{ Id="ad376a8f-9eab-4bb9-9fca-30b01540f445", Name="admin", NormalizedName="ADMIN"},
                new IdentityRole{ Id="ad376a8f-9zxb-4bb9-9fca-30b01540f173", Name="user", NormalizedName="USER"}
            });



            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser[]
            {
                new ApplicationUser 
                {
                    Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                    UserName = "pilot_mig@bk.ru",
                    NormalizedUserName = "PILOT_MIG@BK.RU",
                    Email = "pilot_mig@bk.ru",
                    NormalizedEmail = "PILOT_MIG@BK.RU",
                    EmailConfirmed = false,
                    PasswordHash = hasher.HashPassword(null, "Aa_123456"),
                    SecurityStamp = string.Empty,
                    ClientName="Maxim Malakhov",
                    CompanyName="MaxFunnyApps",
                    DateOfRegistration=DateTime.Now,
                    isBanned=false,
                    isDelited=false
                },

                new ApplicationUser
                {
                    Id = "a17be9c0-aa65-4af8-bd17-00bd9443e575",
                    UserName = "diman@bk.ru",
                    NormalizedUserName = "DIMAN@BK.RU",
                    Email = "diman@bk.ru",
                    NormalizedEmail = "DIMAN@BK.RU",
                    EmailConfirmed = false,
                    PasswordHash = hasher.HashPassword(null, "Aa_123456"),
                    SecurityStamp = string.Empty,
                    ClientName="Dima Ivanov",
                    CompanyName="Dima Constractions",
                    DateOfRegistration=DateTime.Now,
                    isBanned=true,
                    isDelited=false
                },

                new ApplicationUser
                {
                    Id = "a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                    UserName = "sergio@bk.ru",
                    NormalizedUserName = "SERGIO@BK.RU",
                    Email = "sergio@bk.ru",
                    NormalizedEmail = "SERGIO@BK.RU",
                    EmailConfirmed = false,
                    PasswordHash = hasher.HashPassword(null, "Aa_123456"),
                    SecurityStamp = string.Empty,
                    ClientName="Sergei Butovo",
                    CompanyName="Sergio Vine Company",
                    DateOfRegistration=DateTime.Now,
                    isBanned=false,
                    isDelited=false
                }
            });



            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>[]
            {
                new IdentityUserRole<string>
                {
                    RoleId = "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                    UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575"
                },

                new IdentityUserRole<string>
                {
                    RoleId = "ad376a8f-9zxb-4bb9-9fca-30b01540f173",
                    UserId = "a17be9c0-aa65-4af8-bd17-00bd9443e575"
                },

                new IdentityUserRole<string>
                {
                    RoleId = "ad376a8f-9zxb-4bb9-9fca-30b01540f173",
                    UserId = "a16ce9c0-aa65-4af8-bd17-00bd7213e575"
                }
            });



            modelBuilder.Entity<Topic>().HasData(new Topic[]
            {
                new Topic
                { 
                     ApplicationUserId="a18be9c0-aa65-4af8-bd17-00bd9344e575",
                     Date=DateTime.Now, Id=1, isDelited=false, isEdited=false,
                     TopicName="Star ships, interstellars comunications, gelium atomic engines.",
                     TopicDescription="Discussing star ships, their engines and something like this."
                },

                new Topic
                {
                     ApplicationUserId="a17be9c0-aa65-4af8-bd17-00bd9443e575",
                     Date=DateTime.Now, Id=2, isDelited=false, isEdited=false,
                     TopicName="Vine and sigaretes while you are in deep space.",
                     TopicDescription="Discussing we spend time during interstellar voyages."
                },

                new Topic
                {
                     ApplicationUserId="a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                     Date=DateTime.Now, Id=3, isDelited=false, isEdited=false,
                     TopicName="Sports in space.",
                     TopicDescription="How we do sport, while we are in space."
                }
            });




            modelBuilder.Entity<Message>().HasData(new Message[]
            {
                new Message
                {  Id=1, TopicId=1, ApplicationUserId="a18be9c0-aa65-4af8-bd17-00bd9344e575", 
                   Date=DateTime.Now, DateOfLastEdit=DateTime.Now, isDelited=false, isEdited=false,
                   UserName="pilot_mig@bk.ru", 
                   Text="Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem." +
                   " Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, " +
                   "in putant fuisset honestatis qui."
                },

                new Message
                {  Id=2, TopicId=1, ApplicationUserId="a18be9c0-aa65-4af8-bd17-00bd9344e575",
                   Date=DateTime.Now, DateOfLastEdit=DateTime.Now, isDelited=false, isEdited=false,
                   UserName="pilot_mig@bk.ru",
                   Text="Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem." +
                   " Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, " +
                   "in putant fuisset honestatis qui."
                },

                new Message
                {  Id=3, TopicId=1, ApplicationUserId="a18be9c0-aa65-4af8-bd17-00bd9344e575",
                   Date=DateTime.Now, DateOfLastEdit=DateTime.Now, isDelited=false, isEdited=false,
                   UserName="pilot_mig@bk.ru",
                   Text="Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem." +
                   " Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, " +
                   "in putant fuisset honestatis qui."
                }
            });



            modelBuilder.Entity<Message>().HasData(new Message[]
            {
                new Message
                {  Id=4, TopicId=2, ApplicationUserId="a17be9c0-aa65-4af8-bd17-00bd9443e575",
                   Date=DateTime.Now, DateOfLastEdit=DateTime.Now, isDelited=false, isEdited=false,
                   UserName="diman@bk.ru",
                   Text="Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem." +
                   " Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, " +
                   "in putant fuisset honestatis qui."
                },

                new Message
                {  Id=5, TopicId=2, ApplicationUserId="a17be9c0-aa65-4af8-bd17-00bd9443e575",
                   Date=DateTime.Now, DateOfLastEdit=DateTime.Now, isDelited=false, isEdited=false,
                   UserName="diman@bk.ru",
                   Text="Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem." +
                   " Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, " +
                   "in putant fuisset honestatis qui."
                },

                new Message
                {  Id=6, TopicId=2, ApplicationUserId="a17be9c0-aa65-4af8-bd17-00bd9443e575",
                   Date=DateTime.Now, DateOfLastEdit=DateTime.Now, isDelited=false, isEdited=false,
                   UserName="diman@bk.ru",
                   Text="Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem." +
                   " Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, " +
                   "in putant fuisset honestatis qui."
                }
             });



            modelBuilder.Entity<Message>().HasData(new Message[]
            {
                new Message
                {  Id=7, TopicId=3, ApplicationUserId="a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                   Date=DateTime.Now, DateOfLastEdit=DateTime.Now, isDelited=false, isEdited=false,
                   UserName="sergio@bk.ru",
                   Text="Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem." +
                   " Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, " +
                   "in putant fuisset honestatis qui."
                },

                new Message
                {  Id=8, TopicId=3, ApplicationUserId="a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                   Date=DateTime.Now, DateOfLastEdit=DateTime.Now, isDelited=false, isEdited=false,
                   UserName="sergio@bk.ru",
                   Text="Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem." +
                   " Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, " +
                   "in putant fuisset honestatis qui."
                },

                new Message
                {  Id=9, TopicId=3, ApplicationUserId="a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                   Date=DateTime.Now, DateOfLastEdit=DateTime.Now, isDelited=false, isEdited=false,
                   UserName="sergio@bk.ru",
                   Text="Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem." +
                   " Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, " +
                   "in putant fuisset honestatis qui."
                }
             });


            base.OnModelCreating(modelBuilder);
        }
    }
}
