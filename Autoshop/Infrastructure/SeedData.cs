using Autoshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Autoshop.Infrastructure
{
    public class SeedData
    {

        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category alternator = new Category { Name = "Alternator", Slug = "alternator" };
                Category battery = new Category { Name = "Battery", Slug = "battery" };
                Category lights = new Category { Name = "Lights", Slug = "lights" };
                Category brakepads = new Category { Name = "Brake Pads", Slug = "brake pads" };

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Alternator Black",
                        Slug = "alternator-black",
                        Description = "Black alternator",
                        Price = 89.99M,
                        Category = alternator,
                        Image = "Alternator_Blk.jpg"
                    },
                    new Product
                    {
                        Name = "Alternator White",
                        Slug = "alternator-white",
                        Description = "White alternator",
                        Price = 99.99M,
                        Category = alternator,
                        Image = "Alternator_Wht.jpg"
                    },
                    new Product
                    {
                        Name = "Bosch Battery",
                        Slug = "bosch-battery",
                        Description = "A car battery",
                        Price = 124.99M,
                        Category = battery,
                        Image = "Bosch_Battery1.jpg",
                    },
                    new Product
                    {
                        Name = "Bosch Battery White",
                        Slug = "bosch-battery-white",
                        Description = "A car battery",
                        Price = 110.99M,
                        Category = battery,
                        Image = "Bosch_Battery2.jpg",
                    },
                    new Product
                    {
                        Name = "DieHard Battery",
                        Slug = "diehard-battery",
                        Description = "A car battery",
                        Price = 84.99M,
                        Category = battery,
                        Image = "DieHard_Battery1.jpg",
                    },
                    new Product
                    {
                        Name = "Sylvania Basic",
                        Slug = "sylvania-basic",
                        Description = "A basic car headlight",
                        Price = 29.99M,
                        Category = lights,
                        Image = "Sylvania_Basic.jpg",
                    },
                    new Product
                    {
                        Name = "Sylvania Blue",
                        Slug = "sylvania-blue",
                        Description = "A blue colored headlight",
                        Price = 39.99M,
                        Category = lights,
                        Image = "Sylvania_Blue.jpg",
                    },
                    new Product
                    {
                        Name = "ProSeries OEM",
                        Slug = "proseries-oem",
                        Description = "Car brake pads 2pk.",
                        Price = 39.99M,
                        Category = brakepads,
                        Image = "ProSeries_OEM.jpg",
                    },
                    new Product
                    {
                        Name = "Max Ceramic",
                        Slug = "max-ceramic",
                        Description = "Ceramic brake pads",
                        Price = 79.99M,
                        Category = brakepads,
                        Image = "Max_BrakePads1.jpg",
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
