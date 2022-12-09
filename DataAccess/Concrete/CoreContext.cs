using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DataAccess.Concrete
{
	public class CoreContext : DbContext
	{
        public CoreContext(DbContextOptions options) : base(options)
        {

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


	}
}
