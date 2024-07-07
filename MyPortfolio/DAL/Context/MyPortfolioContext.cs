using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext :  DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;initial Catalog=MyPortfolioDb; integrated Security =true;");
        }
        public DbSet<About> abouts { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Fature> fatures { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Portfolio> portfolios { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
    }
}
