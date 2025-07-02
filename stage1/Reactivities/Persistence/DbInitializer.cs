using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Activities.Any()) return;

        var activities = new List<Activity>
        {
            new ()
            {
                //Id = Guid.NewGuid(),
                Title = "Activity 1",
                Date = DateTime.UtcNow.AddMonths(1),
                Description = "Description for Activity 1",
                Category = "Category 1",
                City = "City 1",
                Venue = "Venue 1",
                Latitude = 34.0522,
                Longitude = -118.2437
            },
            new()
            {
                // Id = Guid.NewGuid(),
                Title = "Activity 2",
                Date = DateTime.UtcNow.AddMonths(2),
                Description = "Description for Activity 2",
                Category = "Category 2",
                City = "City 2",
                Venue = "Venue 2"
            }
        };

        // context.Activities.AddRange(Activities);
        // await context.SaveChangesAsync();
        context.Activities.AddRange(activities);
        await context.SaveChangesAsync();
        //await context.Activities.AddRangeAsync();

    }


}