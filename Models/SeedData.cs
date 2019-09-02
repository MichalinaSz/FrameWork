using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
        public static class SeedData
        {
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new MusicContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<MusicContext>>()))
                {
                    // Look for any movies.
                    if (context.Artists.Any())
                    {
                        return;   // DB has been seeded
                    }

                    context.Artists.AddRange
                    (
                        new Artist
                        {
                           Name="Bob",
                           Bio="Crazy guy",

                        }
                     );
                context.Albums.AddRange(

                    new Album
                    {
                        Title = "IDK",
                        Price = 99
                    });
                    context.SaveChanges();
                }
            }
        }
    
}
