using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace AccentureGTGH_EFCore
{
    public class BooksContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Synopsis> Synopsis { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<AuthorPublisher> AuthorPublishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog=GTGH_EF; " +
            //"Integrated Security = true; Encrypt = false;");

            optionsBuilder.UseSqlServer("Data Source = 192.168.1.21; Initial Catalog = GTGH_EF; User = 'sa'; " +
                "Password = '!Abc123456'; Encrypt = false;");
            base.OnConfiguring(optionsBuilder);

            //add-migration initial
            //update-database
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>().HasKey(x => x.PublisherKey);
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Publishers)
                .WithMany(a => a.Authors)
                .UsingEntity<AuthorPublisher>(
                    ap => ap.HasOne<Publisher>().WithMany(),
                    ap => ap.HasOne<Author>().WithMany()
                 );
        }
    }
}
