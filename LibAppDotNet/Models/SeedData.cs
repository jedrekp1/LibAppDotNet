using LibAppDotNet.Data;
using Microsoft.EntityFrameworkCore;

namespace LibAppDotNet.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBookContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "A",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "A",
                        Price = 7.99M
                    },

                    new Book
                    {
                        Title = "B",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "B",
                        Price = 8.99M
                    },

                    new Book
                    {
                        Title = "C",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "C",
                        Price = 9.99M
                    },

                    new Book
                    {
                        Title = "D",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "D",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
