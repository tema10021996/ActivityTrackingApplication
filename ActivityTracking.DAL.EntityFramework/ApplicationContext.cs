﻿using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ActivityTracking.DomainModel;

namespace ActivityTracking.DAL.EntityFramework
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("ApplicationDB") { }

        public DbSet<JustUser> JustUsers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Status> Statuses { get; set;}
        public DbSet<Reason> Reasons { get; set;}
        public DbSet<Absenсe> Absenсes { get; set;}
        public DbSet<Time> Times { get; set;}
        public DbSet<Report> Reports { get; set;}

    public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}
