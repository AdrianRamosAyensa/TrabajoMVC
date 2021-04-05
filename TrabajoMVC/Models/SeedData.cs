using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabajoMVC.Data;

namespace TrabajoMVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcProductContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcProductContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        nombre = "Kirin 990",
                        precio = 196,
                    },

                    new Product
                    {
                        nombre = "i3 9300",
                        precio = 100,
                    },

                    new Product
                    {
                        nombre = "r3 4200G",
                        precio = 120,
                    },

                    new Product
                    {
                        nombre = "r9 5900X",
                        precio = 500,
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}
