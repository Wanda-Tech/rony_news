using System.Linq;

public static class DbInitializer
{
    public static void Seed(NewsWebsiteContext context)
    {
        if (!context.NewsCategories.Any())
        {
            context.NewsCategories.AddRange(
                new NewsCategory { Name = "Articles", Description = "General articles" },
                new NewsCategory { Name = "Reports", Description = "Detailed reports" },
                new NewsCategory { Name = "Breaking", Description = "Breaking news" }
            );
            context.SaveChanges();
        }

        if (!context.Roles.Any())
        {
            context.Roles.AddRange(
                new Role { Name = "Admin", Description = "Administrator role" },
                new Role { Name = "Editor", Description = "Editor role" }
            );
            context.SaveChanges();
        }
    }
}
