﻿using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete
{
	public class CoreContext : IdentityDbContext<WriterUser, WriterRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
		
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
			var activeConn = configuration.GetSection("ActiveConn").Value;
			optionsBuilder.UseSqlServer(configuration.GetConnectionString(activeConn));
		}
        public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }	
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<Feature> Feature { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Portfolio> Portfolios { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<ToDoList> ToDoLists { get; set; }
		public DbSet<Announcement> Announcements { get; set; }
		public DbSet<WriterMessage> WriterMessages { get; set; }


    }
}
