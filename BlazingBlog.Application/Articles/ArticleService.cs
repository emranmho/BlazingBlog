using BlazingBlog.Domain.Articles;

namespace BlazingBlog.Application.Articles;

public class ArticleService : IArticleService
{
    public List<Article> GetArticles()
    {
        return new List<Article>
        {
            new Article 
            { 
                Id = Guid.NewGuid(), 
                Title = "Introduction to C#", 
                Content = "C# is a modern, object-oriented programming language developed by Microsoft.", 
                CreatedAt = DateTime.UtcNow.AddDays(-10), 
                UpdatedAt = DateTime.UtcNow.AddDays(-5), 
                IsPublished = true 
            },
            new Article 
            { 
                Id = Guid.NewGuid(), 
                Title = "Understanding .NET Core", 
                Content = "Learn about .NET Core and its cross-platform capabilities.", 
                CreatedAt = DateTime.UtcNow.AddDays(-8), 
                UpdatedAt = DateTime.UtcNow.AddDays(-3), 
                IsPublished = true 
            },
            new Article 
            { 
                Id = Guid.NewGuid(), 
                Title = "Working with Entity Framework", 
                Content = "Entity Framework simplifies database interactions in .NET applications.", 
                CreatedAt = DateTime.UtcNow.AddDays(-15), 
                UpdatedAt = DateTime.UtcNow.AddDays(-2), 
                IsPublished = false 
            },
            new Article 
            { 
                Id = Guid.NewGuid(), 
                Title = "REST API Best Practices", 
                Content = "Follow these best practices when designing RESTful APIs.", 
                CreatedAt = DateTime.UtcNow.AddDays(-7), 
                UpdatedAt = DateTime.UtcNow.AddDays(-1), 
                IsPublished = true 
            },
            new Article 
            { 
                Id = Guid.NewGuid(), 
                Title = "Blazor WebAssembly Guide", 
                Content = "Blazor WebAssembly enables building interactive web UIs using C#.", 
                CreatedAt = DateTime.UtcNow.AddDays(-20), 
                UpdatedAt = DateTime.UtcNow.AddDays(-10), 
                IsPublished = false 
            },
            new Article 
            { 
                Id = Guid.NewGuid(), 
                Title = "POS System Architecture", 
                Content = "Learn about POS system architecture and design patterns.", 
                CreatedAt = DateTime.UtcNow.AddDays(-12), 
                UpdatedAt = DateTime.UtcNow.AddDays(-6), 
                IsPublished = true 
            }
        };
    }
}