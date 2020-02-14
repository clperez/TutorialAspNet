using Injora.Models;
using Injora.Services.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injora
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            
            // Creates the database and migrates it.
            context.Database.Migrate();

            if (!context.Projects.Any())
            {
                context.Projects.AddRange(
                new Project
                {
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Category = "Watersports",
                    CampaignMinimum = 275
                },
                new Project
                {
                    Name = "Lifejacket",
                    Description = "Protective and fashionable",
                    Category = "Watersports",
                    CampaignMinimum = 48.95m
                },
                new Project
                {
                    Name = "Soccer Ball",
                    Description = "FIFA-approved size and weight",
                    Category = "Soccer",
                    CampaignMinimum = 19.50m
                },
                new Project
                {
                    Name = "Corner Flags",
                    Description = "Give your playing field a professional touch",
                    Category = "Soccer",
                    CampaignMinimum = 34.95m
                },
                new Project
                {
                    Name = "Stadium",
                    Description = "Flat-packed 35,000-seat stadium",
                    Category = "Soccer",
                    CampaignMinimum = 79500
                },
                new Project
                {
                    Name = "Thinking Cap",
                    Description = "Improve brain efficiency by 75%",
                    Category = "Chess",
                    CampaignMinimum = 16
                },
                new Project
                {
                    Name = "Unsteady Chair",
                    Description = "Secretly give your opponent a disadvantage",
                    Category = "Chess",
                    CampaignMinimum = 29.95m
                },
                new Project
                {
                    Name = "Human Chess Board",
                    Description = "A fun game for the family",                
                    Category = "Chess",
                    CampaignMinimum = 75
                },
                new Project
                {
                    Name = "Bling-Bling King",
                    Description = "Gold-plated, diamond-studded King",
                    Category = "Chess",
                    CampaignMinimum = 1200
                }
                );
                context.SaveChanges();
            }
        }
    }
}
