using Microsoft.EntityFrameworkCore;

namespace PruebaAPI1.Views
{
    public class DisneyContext : DbContext

    {
        public DisneyContext(DbContextOptions options) : base(options)
        {
         
            
        }

       


        public DbSet<UserModel> User { get; set; }
        public DbSet<CommentModel> Comments { get; set; }

        public DbSet<PostModel> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;database=Disney;Trusted_Connection=True");
        }


       
    }



}

  


