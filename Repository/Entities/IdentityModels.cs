using Microsoft.AspNetCore.Identity;
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
                new IdentityRole{ Id="4", Name="user"},
                new IdentityRole{ Id="5", Name="admin"}
            });


            modelBuilder.Entity<ApplicationUser>().HasData( new ApplicationUser[] 
            {
                new ApplicationUser{
                 Id ="6", Email="pilot_mig@bk.ru", DateOfRegistration=DateTime.Now,

                 PasswordHash="AQAAAAEAACcQAAAAELTmZcgKdl+Ye8OYjDlB9UL0T3rh4shvu7rUs0RIHO9l3P0iklFjDyovFXW3TzNjiw==",

                 isBanned=false,
                 isDelited=false},


                 new ApplicationUser{
                 Id ="7", Email="seroga@bk.ru", DateOfRegistration=DateTime.Now,

                 PasswordHash="AQAAAAEAACcQAAAAEIKR2w0DCbHSRcKJ+8QJWT3hpO0+2lMgz2wKfJL7HeOA3sTuSFjLCIqcl4y+E1qQNg==",

                 isBanned=false,
                 isDelited=false},


                 new ApplicationUser{
                 Id ="8", Email="diman@bk.ru", DateOfRegistration=DateTime.Now,

                 PasswordHash="AQAAAAEAACcQAAAAECrN6vu9cJrPmHRVyuneUwwtGvDSmbHDiqwJxcpuyF54fBc3cFS4NTalxRp0d+uNqA==",

                 isBanned=false,
                 isDelited=false}

            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
