using Microsoft.EntityFrameworkCore;

namespace FAQProject.Models
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 
        }
        public DbSet<FAQ> FAQs { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Topic> Topics { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "gen", Name = "General" },
                new Category { CategoryId = "hist", Name = "History"}
                );
            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "boot", Name = "Bootstrap" },
                new Topic { TopicId = "csharp", Name = "C#" },
                new Topic { TopicId = "js", Name = "JavaScript" }
                );
            modelBuilder.Entity<FAQ>().HasData(
                new FAQ
                {
                    FAQId = 1,
                    Question = "What is Bootstrap?",
                    Answer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                    CategoryId = "gen",
                    TopicId = "boot"
                },
                new FAQ
                {
                    FAQId = 2,
                    Question = "What is C#?",
                    Answer = "A general purpose object oriented language that uses a concise, Java-like syntax.",
                    CategoryId = "gen",
                    TopicId = "csharp"
                },
                new FAQ
                {
                    FAQId = 3,
                    Question = "What is JavaScript?",
                    Answer = "A general purpose scripting language that executes in a web browser.",
                    CategoryId = "gen",
                    TopicId = "js"
                },
                new FAQ
                {
                    FAQId = 4,
                    Question = "When was Bootstrap first released?",
                    Answer = "In 2011.",
                    CategoryId = "hist",
                    TopicId = "boot"
                },
                new FAQ
                {
                    FAQId = 5,
                    Question = "When was C# first released?",
                    Answer = "In 2002.",
                    CategoryId = "hist",
                    TopicId = "csharp"
                },
                new FAQ
                {
                    FAQId = 6,
                    Question = "When was JavaScript first released?",
                    Answer = "In 1995.",
                    CategoryId = "hist",
                    TopicId = "js"
                }
                );
        }
    }
}
